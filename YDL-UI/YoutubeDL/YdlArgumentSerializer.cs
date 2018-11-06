using ByteSizeLib;
using Maxstupo.YdlUi.ArgumentBuilder;

namespace Maxstupo.YdlUi.YoutubeDL {

    public class YdlArgumentSerializer : ArgumentSerializer {

        public YdlArgumentSerializer() {
            ValueTranslators.Add(typeof(ByteSize), (a, t, v) => ((ByteSize)v).Bytes.ToString("#.#"));
        }

    }

}
