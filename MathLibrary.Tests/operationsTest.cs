using Xunit;
using MathLibrary;

namespace MathLibrary.Tests
{
    public class operationsTest
    {
        private Operations op;
        private double result;

        [Fact]
        public void Power_2_to_the_3rd()
        {
            op = new Operations();
            result = op.Power(2, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Power_2_to_the_0()
        {
            op = new Operations();
            result = op.Power(2, 0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Power_2_to_the_10()
        {
            op = new Operations();
            result = op.Power(2, 10);
            Assert.Equal(1024, result);
        }

        [Fact] //In C# an int can have a max value of 2,147,483,647. (32 bit)
               //  May be beneficial to swap types to floating point nums or doubles.
               // 2^31 = 2,147,483,648
        public void Power_2_to_the_31_edge_case()
        {
            op = new Operations();
            result = op.Power(2, 31);
            Assert.Equal(2147483647, result - 1);
            Assert.NotEqual(2147483647, result);
        }

        [Fact]
        public void AbsoluteVal_of_negative_one()
        {
            op = new Operations();
            result = op.AbsoluteVal(-1.0);
            Assert.Equal(1, result);
        }

               [Fact]
        public void AbsoluteVal_of_one()
        {
            op = new Operations();
            result = op.AbsoluteVal(1.0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void AbsoluteVal_of_negative_one_half()
        {
            op = new Operations();
            result = op.AbsoluteVal(-0.5);
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void Power_2_to_negative_one()
        {
            op = new Operations();
            result = op.Power(2, -1);
            Assert.Equal(.5, result);
        }

        [Fact]
        public void Inverse_of_7()
        {
            op = new Operations();
            result = op.Inverse(7.0);
            Assert.Equal(1.0 / 7.0, result);
        }
        
    }
}
