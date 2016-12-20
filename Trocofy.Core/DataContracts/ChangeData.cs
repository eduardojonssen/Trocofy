using System.Collections.Generic;

namespace Trocofy.Core.DataContracts {
    public class ChangeData {
        
        public string Name { get; set; }

        public Dictionary<uint, uint> ChangeDictionary { get; set; }
    }
}
