using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvestmentCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public decimal Principal { get; set; } = 10000m;

        //private decimal Principal = 10000m;

        private decimal rateOfProductA = 0.03m;
        private decimal rateOfProductB = 0.0295m;

        private int periodOfInvestmentForSimpleInterest = 2; // simple interest for 2 years
        private int periodOfInvestmentInMonthsCompounded = 24; // compound interest for 2 years


        public decimal CalculateInterestOnProductA(decimal interestA)
        {
            interestA = Principal * rateOfProductA * periodOfInvestmentForSimpleInterest;

            return interestA;
        }

        public decimal CalculateInterestOnProductB(decimal interestB)
        {
            interestB = Principal * (decimal)Math.Pow(1 + (double)rateOfProductB / 12, periodOfInvestmentInMonthsCompounded) - Principal;

            return interestB;
        }
    }
}
