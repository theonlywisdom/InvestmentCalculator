using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator.Model
{
    public class InvestmentProduct
    {
        public decimal Pricipal { get; set; }
        public decimal Interest { get; set; }
        public int Time { get; set; }
    }
}
