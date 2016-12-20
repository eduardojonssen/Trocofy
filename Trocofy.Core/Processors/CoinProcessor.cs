using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Processors {
    public class CoinProcessor : AbstractProcessor {

        public uint[] coinList = new uint[] { 100, 50, 25, 10, 5};

        public CoinProcessor() { }

        public override uint[] GetAvailableValues() {
            return this.coinList;
        }

        public override string GetName() {
            return "Moeda";
        }
    }
}
