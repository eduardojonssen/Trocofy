using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Services {
    public class LogManager {
        public void CreateLog(object data, string method) {
            AbstractLog log = LogFactory.Create(System.Configuration.ConfigurationManager.AppSettings["LogType"]);

            log.CreateMessage(data, method);
        }
    }
}
