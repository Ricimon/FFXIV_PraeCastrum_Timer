using FileHelpers;
using System;

namespace Ricimon.FFXIV_PraeCastrum_Timer.Models
{
    [DelimitedRecord(",")]
    public class RunCheckpoint
    {
        public string Label { get; set; }

        /// <summary>
        /// 24-hr timestamp of when the checkpoint was recorded.
        /// Be sure not to have timestamps that span multiple days.
        /// </summary>
        [FieldConverter(ConverterKind.Date, "HH:mm:ss.fff")]
        [FieldNullValue(typeof(DateTime), "00:00:00.000")]
        public DateTime Timestamp { get; set; }

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string TriggerMessage { get; set; }
    }
}
