using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.DataContracts {
    public abstract class AbstractRequest {

        public AbstractRequest() {
            this.ValidationReport = new List<Report>();
        }

        public bool IsValid {
            get {
                this.ValidationReport.Clear();
                this.Validate();
                return (this.ValidationReport.Any() == false);
            }
        }

        public List<Report> ValidationReport { get; set; }

        public void AddError(string field, string message) {

            Report report = new Report();

            report.Field = field;
            report.Message = message;

            this.ValidationReport.Add(report);
        }

        public abstract void Validate();
    }
}
