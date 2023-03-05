using Lab2IO2;

namespace Lab2Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            int result = StringCalculator.SumString("");
            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("12", 12)]
        [InlineData("32", 32)]
        [InlineData("2", 2)]
        public void SingleNumberReturnsValue(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [InlineData("12,2", 14)]
        [InlineData("32,1", 33)]
        [InlineData("2,4", 6)]
        public void ComaSumValues(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [InlineData("12\n2", 14)]
        [InlineData("32\n1", 33)]
        [InlineData("2\n4", 6)]
        public void NewLineSumm(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [InlineData("12\n2,4", 18)]
        [InlineData("32\n1,2", 35)]
        [InlineData("2\n4,2,2", 10)]
        public void MultiSeparatedValues(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("-12\n2,4")]
        [InlineData("32\n1,-2")]
        [InlineData("2\n-4,2,2")]
        public void NegativeValues(string str)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.SumString(str));
        }

        [Theory]
        [InlineData("12\n2000,4", 16)]
        [InlineData("32\n1000,2", 1034)]
        [InlineData("2\n4000,2,2", 6)]
        public void IgnoreHignerThan1000(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [InlineData("12\n2000,4", 16)]
        [InlineData("32\n1000,2", 1034)]
        [InlineData("2\n4000,2,2", 6)]
        public void IgnoreHignerThan10002(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }
    }
}