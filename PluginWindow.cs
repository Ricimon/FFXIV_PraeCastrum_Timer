using Ricimon.FFXIV_PraeCastrum_Timer.Models;
using System;
using System.Windows.Forms;

namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    public partial class PluginWindow : UserControl
    {
        private readonly RunManager _runManager;

        public PluginWindow(RunManager runManager)
        {
            _runManager = runManager;
            InitializeComponent();
        }

        private void PluginWindow_Load(object sender, EventArgs e)
        {
            UpdateRunStateLabels(null);
            UpdateRunResultLabels(null);

            _runManager.RunStateChanged += UpdateRunStateLabels;
            _runManager.OnRunEnded += UpdateRunResultLabels;

            var timer = new Timer();
            timer.Interval = 250;
            timer.Start();
            timer.Tick += UpdateTimers;
        }

        private void UpdateRunStateLabels(RunState runState)
        {
            runName.Text = runState?.RunName;
            lastCheckpoint.Text = runState?.LastCheckpointLabel;

            forceStartCastrumButton.Visible = forceStartPraetoriumButton.Visible = runState == null;
            skipCheckpointButton.Visible = runState != null;
        }

        private void UpdateTimers(object sender, EventArgs e)
        {
            var runState = _runManager.RunState;
            runDuration.Text =
                runState != null ? ConvertToDurationOutput(DateTime.Now - runState.RunStartTime, false) : string.Empty;
            cutsceneTimeRemaining.Text =
                runState != null && runState.IsInCutscene ? ConvertToDurationOutput(runState.CurrentCutsceneTimeEnd - DateTime.Now, false) : string.Empty;
        }

        private void UpdateRunResultLabels(RunResult runResult)
        {
            runNameStats.Text = runResult?.RunName;
            runDurationStats.Text =
                runResult != null ? ConvertToDurationOutput(runResult.RunDuration, true) : string.Empty;
            runDurationWithoutCutscenesStats.Text =
                runResult != null ? ConvertToDurationOutput(runResult.RunDurationOutOfCutscenes, true) : string.Empty;
        }

        private string ConvertToDurationOutput(TimeSpan duration, bool showMilliseconds)
        {
            var s = duration.ToString(showMilliseconds ? @"mm\:ss\.fff" : @"mm\:ss");
            var hours = Math.Floor(duration.TotalHours);
            if (hours > 0)
            {
                s = hours.ToString() + ":" + s;
            }
            return s;
        }

        private void forceStartCastrumButton_Click(object sender, EventArgs e)
        {
            _runManager.TryStartRun(Constants.CastrumKey, "FORCE_CASTRUM_START", true);
        }

        private void forceStartPraetoriumButton_Click(object sender, EventArgs e)
        {
            _runManager.TryStartRun(Constants.PraetoriumKey, "FORCE_PRAETORIUM_START", true);
        }

        private void skipCheckpointButton_Click(object sender, EventArgs e)
        {
            _runManager.TryHitCheckpoint("FORCE_CHECKPOINT_HIT", true);
        }

        private void abortRunButton_Click(object sender, EventArgs e)
        {
            _runManager.Reset();
        }
    }
}
