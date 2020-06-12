using System;

namespace Ricimon.FFXIV_PraeCastrum_Timer.Models
{
    public class RunState
    {
        public string RunName { get; set; }

        public string LastCheckpointLabel { get; set; }

        public bool IsInCutscene { get; set; }

        public DateTime CurrentCutsceneTimeEnd { get; set; }

        public DateTime RunStartTime { get; set; }
    }
}
