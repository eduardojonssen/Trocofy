using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.DataContracts {
    public class ComputeChangeRequest : AbstractRequest {

        public ComputeChangeRequest() { }

        public uint ReceivedAmount { get; set; }
        public uint ProductAmount { get; set; }

        public override void Validate() {

            if (this.ReceivedAmount <= 0) {
                this.AddError("ReceivedAmount", "Insira um valor maior do que zero");
            }

            if (this.ProductAmount <= 0) {
                this.AddError("ProductAmount", "Insira um valor maior do que zero");
            }

            if (this.ReceivedAmount < this.ProductAmount) {
                this.AddError("ReceivedAmount", "Insira um valor igual ou maior que o do produto");
            }
        }
    }
}
