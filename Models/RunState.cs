using System;
using System.Collections;
using System.Collections.Generic;

namespace Ricimon.FFXIV_PraeCastrum_Timer.Models
{
    public class RunState
    {
        public string RunName { get; set; }

        public string LastCheckpointLabel { get; set; }

        public DateTime LastCheckpointTime { get; set; }

        public bool IsInCutscene { get; set; }

        public DateTime CurrentCutsceneTimeEnd { get; set; }

        public DateTime RunStartTime { get; set; }

        public TimeSpan FinishedCutscenesDuration { get; set; }

        public IEnumerator<CutsceneInfo> ExpectedCutsceneEnumerator { get; set; }
    }
}
