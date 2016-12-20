using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Processors {
    class SilverProcessor : AbstractProcessor {
        public override uint[] GetAvailableValues() {
            return new uint[] { 50000, 100000 };
        }

        public override string GetName() {
            return "Prata";
        }
    }
}
