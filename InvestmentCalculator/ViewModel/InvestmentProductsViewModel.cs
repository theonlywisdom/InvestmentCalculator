using System;
using System.ComponentModel;

namespace InvestmentCalculator.ViewModel
{
    public class InvestmentProductsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private decimal _interestRate;
        private decimal _investmentAmount;
        private int _compoundingFrequency;

        public InvestmentProductsViewModel()
        {
            InvestmentAmount = 10000;
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                _interestRate = value;
                OnPropertyChanged(nameof(InterestRate));
                OnPropertyChanged(nameof(TotalInterestEarned));
            }
        }


        public decimal InvestmentAmount
        {
            get { return _investmentAmount; }
            set
            {
                _investmentAmount = value;
                OnPropertyChanged(nameof(InvestmentAmount));
                OnPropertyChanged(nameof(TotalInterestEarned));
            }
        }

        public int CompoundingFrequency
        {
            get { return _compoundingFrequency; }
            set
            {
                _compoundingFrequency = value;
                OnPropertyChanged(nameof(CompoundingFrequency));
                OnPropertyChanged(nameof(TotalInterestEarned));
            }
        }


        public decimal TotalInterestEarned
        {
            get
            {
                if (CompoundingFrequency == 1)
                {
                    // Simple interest formula
                    return InvestmentAmount * InterestRate * 2;
                }
                else
                {
                    // Compound interest formula
                    return InvestmentAmount * (decimal)Math.Pow(1 + (double)(InterestRate / CompoundingFrequency), CompoundingFrequency * 2) - InvestmentAmount;
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
