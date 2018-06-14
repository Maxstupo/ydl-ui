using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxstupo.CommandBuilder {
    public class FlagArgument : Argument {
        public FlagArgument(string flag) : base(flag, "{flag}", QuotePolicy.OFF) {

        }
    }
}
