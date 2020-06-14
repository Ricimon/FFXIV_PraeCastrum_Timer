using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricimon.FFXIV_PraeCastrum_Timer.Models
{
    public class RunResult
    {
        public string RunName { get; set; }

        public TimeSpan RunDuration { get; set; }

        public TimeSpan RunDurationOutOfCutscenes { get; set; }

        public DateTime RunStartTime { get; set; }

        public DateTime RunEndTime => RunStartTime + RunDuration;
    }
}
