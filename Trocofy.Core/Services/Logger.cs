using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlp.Framework;

namespace Trocofy.Core.Services {
    public class Logger {

        public Logger() { }

        public void CreateLog(object data, string method, string type) {
            string filePath = "C:/Logs/trocofy.log";
            string directoryPath = Path.GetDirectoryName(filePath);

            if (Directory.Exists(directoryPath) == false) {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = new StreamWriter(filePath, true)) {

                string logMessage = DateTime.UtcNow.ToString() + "; " + type + "; " + method + "; " + Serializer.NewtonsoftSerialize(data);

                writer.WriteLine(logMessage);

                writer.Flush();
            }
        }
    }
}
