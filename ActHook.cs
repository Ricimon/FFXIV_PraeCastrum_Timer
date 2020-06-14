using Advanced_Combat_Tracker;
using Ricimon.FFXIV_PraeCastrum_Timer.Util;
using System;
using System.Windows.Forms;

namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    public class ActHook : IActPluginV1
    {
        public TabPage PluginScreenSpace { get; private set; }

        public Label PluginStatusText { get; private set; }

        private RunManager _runManager;

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            try
            {
                PluginScreenSpace = pluginScreenSpace;
                PluginStatusText = pluginStatusText;

                _runManager = new RunManager(this);

                pluginStatusText.Text = "Ready!";
                Log.Trace("Plugin Ready!");
            }
            catch(Exception e)
            {
                Log.Error(e.ToString());
                SetPluginStatusError(e.ToString());
            }
        }

        public void DeInitPlugin()
        {
            _runManager.Dispose();
        }

        public void SetPluginStatusError(string error)
        {
            PluginStatusText.Text = $"Plugin errored: {error}";
        }

        private readonly Logger Log = Logger.GetLogger();
    }
}
