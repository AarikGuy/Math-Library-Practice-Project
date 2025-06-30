using Xunit;
using MathLibrary;

namespace MathLibrary.Tests
{
    public class FormulasTest
    {
        private FormulasInterface formula;
        private double result;

        [Fact]
        public void AreaOfCircle_Radius_3()
        {
            formula = new Formulas();
            result = formula.AreaOfCircle(3.0);
            Assert.Equal(28.2743, Math.Round(result, 4)); //Rounds to 4 decimal places
        }

        [Fact]
        public void BinomialCoefficient_3_choose_2()
        {
            formula = new Formulas();
            result = formula.BinomialCoefficient(3, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void BinomialCoefficient_3_choose_1()
        {
            formula = new Formulas();
            result = formula.BinomialCoefficient(3, 1);
            Assert.Equal(3, result);
        }

        [Fact]
        public void BinomialCoefficient_3_choose_0()
        {
            formula = new Formulas();
            result = formula.BinomialCoefficient(3, 0);
            Assert.Equal(1, result);
        }
         
        [Fact]
        public void BinomialCoefficient_18_choose_6()
        {
            formula = new Formulas();
            result = formula.BinomialCoefficient(18, 6);
            Assert.Equal(18564, result);
        } 
    }
}