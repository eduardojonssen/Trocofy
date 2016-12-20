using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Processors {
    public abstract class AbstractProcessor {

        public AbstractProcessor() { }

        public abstract uint[] GetAvailableValues();

        public abstract string GetName();

        public virtual Dictionary<uint, uint> Calculate(uint totalChangeAmount) {
            Dictionary<uint, uint> changeDictionary = new Dictionary<uint, uint>();
            uint[] availableValueList = this.GetAvailableValues();

            foreach (uint availableValue in availableValueList.OrderByDescending(p => p)) {
                uint quantityValue = totalChangeAmount / availableValue;

                if(quantityValue != 0) {
                    changeDictionary.Add(availableValue, quantityValue);
                    totalChangeAmount = totalChangeAmount % availableValue;
                }

                if (totalChangeAmount == 0) {
                    break;
                }
            }

            return changeDictionary;
        }


    }
}
