using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Trocofy.Core.Services {
    class EventViewerLogProcessor : AbstractLog {

        protected override void SaveLog(string type, string method, string message) {
            string logSource;
            string logName;
            string logEvent;
            
            string logMessage = type + "; " + method + "; " + message;

            logSource = "Trocofy";
            logName = "Application";
            logEvent = logMessage;

            if (EventLog.SourceExists(logSource) == false)
                EventLog.CreateEventSource(logSource, logName);

            EventLog.WriteEntry(logSource, logEvent);
        }
    }
}
