namespace Maxstupo.YdlUi.Core.YoutubeDl.Binaries.Readers {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IYdlBinaryReader {

        void Read(IYdlBinaryLibrary library,string filepath);

    }

}