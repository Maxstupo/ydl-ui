namespace Maxstupo.YdlUi.Core.Ydl {
    using System;
    using Maxstupo.YdlUi.Core.Arguments;

    public sealed class YdlArgumentSerializer : ArgumentSerializer {

        protected override void Init() {
            base.Init();

            // Translate DateTime objects to the format of "yyyyMMdd".
            ValueTranslators.Add(typeof(DateTime), (a, t, v) => ((DateTime) v).ToString("yyyyMMdd"));
        }

    }

}
