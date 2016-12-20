using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Processors {
    public class CandyProcessor : AbstractProcessor {

        public uint[] candyList = new uint[] { 1, 3 };

        public CandyProcessor() { }

        public override uint[] GetAvailableValues() {
            return this.candyList;
        }

        public override string GetName() {
            return "Bala";
        }
    }
}
