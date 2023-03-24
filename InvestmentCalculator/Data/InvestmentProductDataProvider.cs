using InvestmentCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator.Data
{
    internal class InvestmentProductDataProvider
    {
        public async Task<InvestmentProduct> GetInvestmentAsync()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new InvestmentProduct
            {
                Pricipal = 10000
            };
        }
    }
}
