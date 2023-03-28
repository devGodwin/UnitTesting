using TestNinja.Fundamentals;
using Xunit;
using Assert = Xunit.Assert;

namespace TestNinja.UnitTest.Tests
{
    public class MathTests
    {
        [Fact]
        public void Add_WhenCalled_Returns()
        {
            var math = new Math();
            var result= math.Add(1, 2);
            Assert.Equal(3,result);
        }

        [Fact]
        public void Max_WhenCalled_Returns()
        {
            var math = new Math();
            var result= math.Max(6,7);
            Assert.Equal(7,result);
        }
        
        [Fact]
        public void GetOddNumbers_WhenCalled_Returns()
        {
            var math = new Math();
            var result= math.GetOddNumbers(100);
            Assert.Contains(99,result);
        }
    }
}