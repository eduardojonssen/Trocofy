using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Services {
    public static class Logger { 
        public static void Log(object data, [CallerMemberName]string method = null) {
            LogManager logManager = new LogManager();

            logManager.CreateLog(data, method);
        }
    }
}
