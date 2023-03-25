using System;
using System.ComponentModel;

namespace InvestmentCalculator.ViewModel
{
    public class InvestmentProductsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private decimal _simpleInterestRate;
        private decimal _simpleInterest;
        private decimal _compountInterestRate;
        private decimal _compountInterest;
        private decimal _investmentAmount;

        public InvestmentProductsViewModel()
        {
            InvestmentAmount = 10000m;
            SimpleInterestRate = 3m;
            CompoundInterestRate = 2.95m;
        }

        public decimal SimpleInterestRate
        {
            get { return _simpleInterestRate; }
            set
            {
                _simpleInterestRate = value;
                OnPropertyChanged(nameof(SimpleInterestRate));
            }
        }

        public decimal SimpleInterest
        {
            get { return _simpleInterest; }
            set
            {
                _simpleInterest = value;
                OnPropertyChanged(nameof(SimpleInterest));
            }
        }

        public decimal CompoundInterestRate
        {
            get { return _compountInterestRate; }
            set
            {
                _compountInterestRate = value;
                OnPropertyChanged(nameof(CompoundInterestRate));
            }
        }

        public decimal CompoundInterest
        {
            get { return _compountInterest; }
            set
            {
                _compountInterest = value;
                OnPropertyChanged(nameof(CompoundInterest));
            }
        }


        public decimal InvestmentAmount
        {
            get { return _investmentAmount; }
            set
            {
                _investmentAmount = value;
                OnPropertyChanged(nameof(InvestmentAmount));
            }
        }

        public void CalculateInterest()
        {
            decimal timePeriod = 2m; 
            decimal decimalSimpleInterestRate = SimpleInterestRate / 100m;
            decimal decimalCompoundInterestRate = CompoundInterestRate / 100m;
            int compoundingPeriod = 12;

            SimpleInterest = InvestmentAmount * decimalSimpleInterestRate * timePeriod;

            // Calculate compound interest with monthly compounding
            decimal monthlyInterestRate = decimalCompoundInterestRate / compoundingPeriod;
            decimal compoundedAmount = InvestmentAmount * (decimal)Math.Pow(1 + (double)monthlyInterestRate, (double)(timePeriod * compoundingPeriod));
            CompoundInterest = compoundedAmount - InvestmentAmount;
        }



        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
