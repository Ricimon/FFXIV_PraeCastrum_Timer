using Advanced_Combat_Tracker;
using Ricimon.FFXIV_PraeCastrum_Timer.Models;
using Ricimon.FFXIV_PraeCastrum_Timer.Util;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ricimon.FFXIV_PraeCastrum_Timer
{
    public class RunManager : IDisposable
    {
        public RunState RunState { get; private set; }

        public event Action<RunState> RunStateChanged;

        public event Action<RunResult> OnRunEnded;

        private readonly ActHook _actHook;
        private readonly RunDataLoader _runDataLoader;

        public RunManager(ActHook actHook)
        {
            _actHook = actHook;

            _runDataLoader = new RunDataLoader();
            _runDataLoader.LoadRunData();

            actHook.PluginScreenSpace.Controls.Add(new PluginWindow(this));
            actHook.PluginScreenSpace.Text = "FFXIV PraeCastrum Timer";

            ActGlobals.oFormActMain.BeforeLogLineRead += OnBeforeLogLineRead;
        }

        public void Dispose()
        {
            ActGlobals.oFormActMain.BeforeLogLineRead -= OnBeforeLogLineRead;
        }

        public void Reset()
        {
            Log.Info("Resetting run.");
            RunState = null;
            RunStateChanged?.Invoke(RunState);
        }

        public bool TryStartRun(string runKey, string input, bool forceStart = false)
        {
            if (RunState != null)
            {
                Log.Warning("A run is already in progress. Cannot start new run!");
                return false;
            }

            var runCutscenes = _runDataLoader.RunData[runKey].Cutscenes;
            var firstCutscene = runCutscenes.First();
            if (MatchesTriggerMessage(input, firstCutscene.StartTriggerRegex) || forceStart)
            {
                var cutsceneEnumerator = runCutscenes.GetEnumerator();
                cutsceneEnumerator.MoveNext();
                RunState = new RunState()
                {
                    RunName = runKey,
                    IsInCutscene = true,
                    CurrentCutsceneTimeEnd = DateTime.Now + firstCutscene.Duration,
                    LastCheckpointLabel = firstCutscene.Label,  // assume a run starts on a cutscene
                    LastCheckpointTime = DateTime.Now,
                    RunStartTime = DateTime.Now,
                    ExpectedCutsceneEnumerator = cutsceneEnumerator,
                };
                var log = string.Join("\n",
                    $"Run start detected. Now running: {RunState.RunName}",
                    $"Trigger message: {input}"
                );
                Log.Info(log);
                RunStateChanged?.Invoke(RunState);
                return true;
            }
            return false;
        }

        public bool TryHitCheckpoint(string input, bool forceCheckpointHit = false)
        {
            if (RunState == null)
            {
                Log.Warning("No run is in progress. Cannot try to hit a checkpoint");
                return false;
            }

            var expectedCutscene = RunState.ExpectedCutsceneEnumerator.Current;
            if (RunState.IsInCutscene)
            {
                if (MatchesTriggerMessage(input, expectedCutscene.EndTriggerRegex) || forceCheckpointHit)
                {
                    RunState.ExpectedCutsceneEnumerator.MoveNext();

                    RunState.IsInCutscene = false;
                    RunState.FinishedCutscenesDuration += DateTime.Now - RunState.LastCheckpointTime;
                    RunState.LastCheckpointLabel = expectedCutscene.Label + "_end";
                    RunState.LastCheckpointTime = DateTime.Now;
                    var log = string.Join("\n",
                        $"Cutscene end hit. Checkpoint label: {RunState.LastCheckpointLabel}",
                        $"Trigger message: {input}"
                    );
                    RunStateChanged?.Invoke(RunState);
                    return true;
                }
            }
            else
            {
                if (MatchesTriggerMessage(input, expectedCutscene.StartTriggerRegex) || forceCheckpointHit)
                {
                    RunState.IsInCutscene = true;
                    RunState.CurrentCutsceneTimeEnd = DateTime.Now + expectedCutscene.Duration;
                    RunState.LastCheckpointLabel = expectedCutscene.Label;
                    RunState.LastCheckpointTime = DateTime.Now;
                    RunStateChanged?.Invoke(RunState);

                    if (expectedCutscene.IsEnding)
                    {
                        var runResult = new RunResult()
                        {
                            RunName = RunState.RunName,
                            RunDuration = DateTime.Now - RunState.RunStartTime,
                            RunStartTime = RunState.RunStartTime,
                        };
                        runResult.RunDurationOutOfCutscenes = runResult.RunDuration - RunState.FinishedCutscenesDuration;
                        var log = string.Join("\n",
                            $"{runResult.RunName} run finished! Stats:",
                            $"Total run duration: {runResult.RunDuration}",
                            $"Total run duration outside of cutscenes: {runResult.RunDurationOutOfCutscenes}"
                        );
                        Log.Info(log);

                        OnRunEnded?.Invoke(runResult);

                        Reset();
                    }

                    return true;
                }
            }
            return false;
        }

        private void OnBeforeLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            try
            {
                if (isImport) { return; }
#if DEBUG
                Log.Trace(logInfo.logLine);
#endif

                var logLine = logInfo.logLine;
                if (RunState == null)
                {
                    foreach (var potentialRunKey in _runDataLoader.RunData.Keys)
                    {
                        if (TryStartRun(potentialRunKey, logLine)) { break; }
                    }
                }
                else
                {
                    TryHitCheckpoint(logLine);
                }
            }
            catch(Exception e)
            {
                Log.Error(e.ToString());
                _actHook.SetPluginStatusError(e.ToString());
            }
        }

        private bool MatchesTriggerMessage(string input, string triggerMessageRegex)
        {
            // An example log message looks like this:
            // [19:57:08.000] 00:003d:Gaius van Baelsar:Hmph! How very glib. And do you believe in Eorzea?
            // Skip the first characters of timestamp data
            input = input.Substring("[00:00:00.000] ".Length);
            return Regex.Match(input, triggerMessageRegex).Success;
        }

        private Logger Log = Logger.GetLogger();
    }
}
