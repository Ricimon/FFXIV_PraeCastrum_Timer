using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricimon.FFXIV_PraeCastrum_Timer.Models
{
    public class CutsceneInfo
    {
        public string Label { get; set; }

        public TimeSpan Duration { get; set; }

        public string StartTriggerRegex { get; set; }

        public string EndTriggerRegex { get; set; }

        /// <summary>
        /// If the start of this cutscene marks the end of the run.
        /// </summary>
        public bool IsEnding { get; set; }
    }
}
