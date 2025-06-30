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

        [Fact] //An int can have a max value of 2,147,483,647. (32 bit)
               // 2^31 = 2,147,483,648
        public void Power_2_to_the_31_edge_case()
        {
            op = new Operations();
            result = op.Power(2, 31);
            Assert.Equal(2147483647, result - 1); //Tests the integer edge case.
            Assert.Equal(2147483648.0, result); //Tests the expected behavior of a double.
            Assert.NotEqual(2147483647, result); //Tests more of the integer edge case.
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

        [Fact]
        public void Inverse_of_1_over_7()
        {
            op = new Operations();
            result = op.Inverse(1.0 / 7.0);
            Assert.Equal(7.0, result);
        }

        [Fact]
        public void Inverse_of_0()
        {
            op = new Operations();

            Assert.Throws<ArithmeticException>(() => op.Inverse(0));
        }

        [Fact]
        public void _2_Cubed()
        {
            op = new Operations();
            result = op.Cubed(2);
            Assert.Equal(8, result);
        }


        [Fact]
        public void _3_Cubed()
        {
            op = new Operations();
            result = op.Cubed(3);
            Assert.Equal(27, result);
        }

                [Fact]
        public void negative_2_Cubed()
        {
            op = new Operations();
            result = op.Cubed(-2);
            Assert.Equal(-8, result);
        }
        
    }
}
