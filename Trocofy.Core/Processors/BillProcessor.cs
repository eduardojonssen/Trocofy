
using System;
using System.Collections.Generic;

namespace Trocofy.Core.Processors {
    public class BillProcessor : AbstractProcessor {

        public uint[] billList = new uint[] { 10000, 5000, 2000, 1000, 500, 200 };

        public BillProcessor() { }

        public override uint[] GetAvailableValues() {
            return this.billList;
        }

        public override string GetName() {
            return "Nota";
        }
    }
}
