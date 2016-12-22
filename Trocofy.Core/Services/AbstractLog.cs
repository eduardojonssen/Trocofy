using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Trocofy.Core.DataContracts;

namespace Trocofy.Core.Services {
    public abstract class AbstractLog {

        public AbstractLog() { }

        public void CreateMessage(object data, string method) {
            string type = string.Empty;

            if (data is Exception) {
                type = "EXCEPTION";
            }
            else if (data is AbstractRequest) {
                type = "REQUEST";
            }
            else if (data is AbstractResponse) {
                type = "RESPONSE";
            }
            else {
                type = "UNKNOWN";
            }
            
            string message = Serializer.NewtonsoftSerialize(data);

            this.SaveLog(type, method, message);
        }

        protected abstract void SaveLog(string type, string method, string message);
    }
}
