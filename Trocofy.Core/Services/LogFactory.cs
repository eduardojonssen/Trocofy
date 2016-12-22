using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Services {
    public static class LogFactory {

        public static AbstractLog Create(string logType) {

            if (logType == "FileLog") {
                return new FileLogProcessor();
            }
            else if (logType == "EventViewerLog") {
                return new EventViewerLogProcessor();
            }

            return new FileLogProcessor();
        }
    }
}
