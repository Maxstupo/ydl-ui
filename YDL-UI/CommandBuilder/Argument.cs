using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxstupo.CommandBuilder {


    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Argument : Attribute {
        public string Flag { get; set; }
        public string Template { get; set; }
        public QuotePolicy QuotePolicy { get; set; }
        public EnumCasePolicy EnumCase { get; set; }
        public int Order { get; set; }

        public Argument(string flag, string template = "{flag} {value}", QuotePolicy quotePolicy = QuotePolicy.WHEN_NECESSARY, EnumCasePolicy enumCase = EnumCasePolicy.LOWERCASE, int order = 0) {
            this.Flag = flag?.ToLower() ?? throw new Exception("Flag can not be null!");
            this.Template = template?.ToLower() ?? throw new Exception("Template can not be null!");
            this.QuotePolicy = quotePolicy;
            this.EnumCase = enumCase;
            this.Order = order;
        }
    }


}
