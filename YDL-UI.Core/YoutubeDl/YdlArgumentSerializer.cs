namespace Maxstupo.YdlUi.Core.YoutubeDl {
    using System;
    using ByteSizeLib;
    using Maxstupo.YdlUi.Core.Arguments;

    public class YdlArgumentSerializer : ArgumentSerializer {

        protected override void Init() {
            base.Init();

            // Translate DateTime objects to the format of "yyyyMMdd".
            ValueTranslators.Add(typeof(DateTime), (a, v) => ((DateTime) v).ToString("yyyyMMdd"));

            // Translate TimeSpan objects to seconds.
            ValueTranslators.Add(typeof(TimeSpan), (a, v) => ((int) ((TimeSpan) v).TotalSeconds).ToString());

            // Translate ByteSize to bytes.
            ValueTranslators.Add(typeof(ByteSize), (a, v) => {
                long bytes = (long) ((ByteSize) v).Bytes;
                return bytes == 0 ? "0" : bytes.ToString();
            });

        }

    }

}
