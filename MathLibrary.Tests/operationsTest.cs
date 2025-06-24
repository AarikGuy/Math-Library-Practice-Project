using Xunit;
using MathLibrary;

namespace MathLibrary.Tests
{
    public class operationsTest
    {
        private Operations op;
        private int result;

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
        public void Inverse_of_7()
        {
            op = new Operations();
            result = (int)op.Inverse(7);
            Assert.Equal(1 / 7, result);
        }
    }
}
