using System;
using System.Linq;
using System.Collections.Generic;
using Trocofy.Core.DataContracts;
using Trocofy.Core.Processors;

namespace Trocofy.Core {
    public class TrocofyManager {
        public ComputeChangeResponse ComputeChange(ComputeChangeRequest request) {
            ComputeChangeResponse response = new ComputeChangeResponse();

            try {
                // Verifica se os dados recebidos são válidos.
                if (request.IsValid == false) {
                    response.OperationReport = request.ValidationReport;
                    return response;
                }

                uint change = CalculateTotalChangeAmount(request.ReceivedAmount, request.ProductAmount);
                uint totalChangeAmount = change;
                List<ChangeData> changeDataList = new List<ChangeData>();

                while (change > 0) {
                    AbstractProcessor processor = ProcessorFactory.Create(change);

                    if (processor == null) {
                        Report report = new Report();
                        report.Message = "Ocorreu um erro: Não há troco disponível";
                        response.OperationReport.Add(report);
                        return response;
                    }

                    Dictionary<uint, uint> changeDictionary = processor.Calculate(change);

                    ChangeData changeData = new ChangeData() {
                        Name = processor.GetName(),
                        ChangeDictionary = changeDictionary
                    };

                    changeDataList.Add(changeData);
                    long totalCurrentAmount = changeDictionary.Sum(p => (p.Value * p.Key));

                    change -= (uint)totalCurrentAmount;
                }

                response.ChangeDataList = changeDataList;
                response.TotalChangeAmount = totalChangeAmount;
                response.Success = true;

            }
            catch (Exception e) {
                Report report = new Report();
                report.Message = "Ocorreu um erro: não foi possível processar sua operação.";
                response.OperationReport.Add(report);
            }

            return response;
        }

        private uint CalculateTotalChangeAmount(uint receivedAmount, uint productAmount) {
            return receivedAmount - productAmount;
        }
    }
}
