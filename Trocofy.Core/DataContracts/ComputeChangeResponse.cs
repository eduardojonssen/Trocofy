using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.DataContracts {
    public sealed class ComputeChangeResponse : AbstractResponse {

        public ComputeChangeResponse() : base() {
            this.ChangeDataList = new List<ChangeData>();
        }

        public List<ChangeData> ChangeDataList { get; set; }

        public uint TotalChangeAmount { get; set; }
    }
}