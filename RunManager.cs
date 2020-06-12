using Advanced_Combat_Tracker;
using Ricimon.FFXIV_PraeCastrum_Timer.Models;
using Ricimon.FFXIV_PraeCastrum_Timer.Util;
using System;

namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    public class RunManager : IDisposable
    {
        private RunState _runState;

        private readonly ActHook _actHook;

        public RunManager(ActHook actHook)
        {
            _actHook = actHook;

            var runDataLoader = new RunDataLoader();
            runDataLoader.LoadRunData();

            ActGlobals.oFormActMain.BeforeLogLineRead += OnBeforeLogLineRead;
        }

        public void Dispose()
        {
            ActGlobals.oFormActMain.BeforeLogLineRead -= OnBeforeLogLineRead;
        }

        private void OnBeforeLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            try
            {

            }
            catch(Exception e)
            {
                Log.Error(e.ToString());
                _actHook.SetPluginStatusError(e.ToString());
            }
        }

        private Logger Log = Logger.GetLogger();
    }
}
