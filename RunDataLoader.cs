using FileHelpers;
using Ricimon.FFXIV_PraeCastrum_Timer.Models;
using Ricimon.FFXIV_PraeCastrum_Timer.Util;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    public class RunDataLoader
    {
        public Dictionary<string, RunData> RunData { get; } = new Dictionary<string, RunData>();

        private readonly string CastrumDataResourceName;
        private readonly string PraetoriumDataResourceName;

        private readonly FileHelperEngine<RunCheckpoint> _engine = new FileHelperEngine<RunCheckpoint>();

        public RunDataLoader()
        {
            // https://stackoverflow.com/a/3314213
            var resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            CastrumDataResourceName = resourceNames.Single(str => str.EndsWith("CastrumData.csv"));
            PraetoriumDataResourceName = resourceNames.Single(str => str.EndsWith("PraetoriumData.csv"));
        }

        public void LoadRunData()
        {
            RunData[Constants.CastrumKey] = ConstructRunData(CastrumDataResourceName);
            RunData[Constants.PraetoriumKey] = ConstructRunData(PraetoriumDataResourceName);
        }

        private RunData ConstructRunData(string resourceName)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var runCheckpoints = _engine.ReadStream(reader);
                Log.Debug($"{resourceName} loaded? {runCheckpoints != null}");

                List<CutsceneInfo> cutscenes = new List<CutsceneInfo>();

                CutsceneInfo cutscene = null;
                RunCheckpoint lastCheckpoint = null;
                foreach (var checkpoint in runCheckpoints)
                {
                    if (cutscene == null)
                    {
                        cutscene = new CutsceneInfo
                        {
                            Label = checkpoint.Label,
                            StartTriggerRegex = checkpoint.TriggerMessageRegex,
                            IsEnding = false,
                        };
                        lastCheckpoint = checkpoint;
                    }
                    else
                    {
                        cutscene.EndTriggerRegex = checkpoint.TriggerMessageRegex;
                        cutscene.Duration = checkpoint.Timestamp - lastCheckpoint.Timestamp;
                        cutscenes.Add(cutscene);
                        cutscene = null;
                    }
                }
                // assume last checkpoint doesn't have an accompanying end checkpoint, because it's the end of the run
                cutscene.IsEnding = true;
                cutscenes.Add(cutscene);
                return new RunData
                {
                    Cutscenes = cutscenes,
                };
            }
        }

        private readonly Logger Log = Logger.GetLogger();
    }
}
