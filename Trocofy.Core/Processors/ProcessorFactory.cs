using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocofy.Core.Processors {
    public static class ProcessorFactory {

        public static AbstractProcessor Create(uint changeAmount) {

            AbstractProcessor[] processors = new AbstractProcessor[] {
                new BillProcessor(),
                new CoinProcessor(),
                new CandyProcessor(),
                new SilverProcessor()

                // Adicione novos processadores acima desta linha.
            };

            foreach (AbstractProcessor abstractProcessor  in processors.OrderByDescending(p => p.GetAvailableValues().Max())) {
                if (abstractProcessor.GetAvailableValues().Min() <= changeAmount) {
                    return abstractProcessor;
                }
            }
            return null;
        }
    }
}
