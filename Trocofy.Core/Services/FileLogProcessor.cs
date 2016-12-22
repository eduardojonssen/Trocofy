using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlp.Framework;
using Trocofy.Core.DataContracts;
using System.Runtime.CompilerServices;

namespace Trocofy.Core.Services {
    public class FileLogProcessor : AbstractLog {

        public FileLogProcessor() { }

        protected override void SaveLog(string type, string method, string message) {

            string filePath = "C:/Logs/trocofy.log";
            string directoryPath = Path.GetDirectoryName(filePath);

            if (Directory.Exists(directoryPath) == false) {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = new StreamWriter(filePath, true)) {

                string logMessage = DateTime.UtcNow.ToString() + "; " + type + "; " + method + "; " + message;

                writer.WriteLine(logMessage);

                writer.Flush();
            }
        }
    }
}
