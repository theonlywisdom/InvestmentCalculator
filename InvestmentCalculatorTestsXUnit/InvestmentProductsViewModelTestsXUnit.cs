using InvestmentCalculator.ViewModel;

namespace InvestmentCalculatorTestsXUnit
{
    public class InvestmentProductsViewModelTestsXUnit
    {
        [Fact]
        public void InvestmentAmount_DefaultValue_ShouldBe10000()
        {
            var viewModel = new InvestmentProductsViewModel();
            Assert.Equal(10000m, viewModel.InvestmentAmount);
        }

        [Fact]
        public void SimpleInterestRate_DefaultValue_ShouldBe3()
        {
            var viewModel = new InvestmentProductsViewModel();
            Assert.Equal(3m, viewModel.SimpleInterestRate);
        }

        [Fact]
        public void CompoundInterestRate_DefaultValue_ShouldBe2Point95()
        {
            var viewModel = new InvestmentProductsViewModel();
            Assert.Equal(2.95m, viewModel.CompoundInterestRate);
        }

        [Fact]
        public void SimpleInterest_ShouldBeCalculatedCorrectly()
        {
            var viewModel = new InvestmentProductsViewModel { InvestmentAmount = 10000m, SimpleInterestRate = 5m };
            viewModel.CalculateInterest();
            Assert.Equal(1000m, viewModel.SimpleInterest);
        }

        [Fact]
        public void CompoundInterest_ShouldBeCalculatedCorrectly()
        {
            var viewModel = new InvestmentProductsViewModel { InvestmentAmount = 10000m, CompoundInterestRate = 6m };
            viewModel.CalculateInterest();
            Assert.Equal(1271.60m, viewModel.CompoundInterest, precision: 2);
        }
    }
}