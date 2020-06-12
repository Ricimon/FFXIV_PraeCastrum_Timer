using Advanced_Combat_Tracker;
using FileHelpers;
using Ricimon.FFXIV_PraeCastrum_Timer.Models;
using Ricimon.FFXIV_PraeCastrum_Timer.Util;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    public class RunDataLoader
    {
        public IEnumerable<CutsceneInfo> PraetoriumCutscenes { get; private set; }

        private readonly string RunDataPath = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, $"Plugins\\{Assembly.GetCallingAssembly().GetName().Name}\\");
        private readonly string PraetoriumDataPath;

        private readonly FileHelperEngine<RunCheckpoint> _engine = new FileHelperEngine<RunCheckpoint>();

        public RunDataLoader()
        {
            PraetoriumDataPath = Path.Combine(RunDataPath, "PraetoriumData.csv");
        }

        public void LoadRunData()
        {
            PraetoriumCutscenes = ConstructCutscenes(PraetoriumDataPath);
        }

        private IEnumerable<CutsceneInfo> ConstructCutscenes(string runDataPath)
        {
            var runCheckpoints = _engine.ReadFile(runDataPath);
            Log.Debug($"{runDataPath} loaded? {runCheckpoints != null}");

            List<CutsceneInfo> cutscenes = new List<CutsceneInfo>();

            CutsceneInfo cutscene = null;
            RunCheckpoint lastCheckpoint = null;
            foreach(var checkpoint in runCheckpoints)
            {
                if (cutscene == null)
                {
                    cutscene = new CutsceneInfo
                    {
                        Label = checkpoint.Label,
                    };
                    lastCheckpoint = checkpoint;
                }
                else
                {
                    cutscene.Duration = checkpoint.Timestamp - lastCheckpoint.Timestamp;
                    cutscenes.Add(cutscene);
                    cutscene = null;
                }
            }
            return cutscenes;
        }

        private readonly Logger Log = Logger.GetLogger();
    }
}
