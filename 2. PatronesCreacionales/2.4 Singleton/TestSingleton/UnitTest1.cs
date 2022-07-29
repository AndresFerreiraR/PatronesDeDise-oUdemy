using SingletonPattern.Classes;
using Xunit;

namespace TestSingleton
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var finder = new SingletonFinder();
            var total = finder.GetTotalPopulation(new[] { "London", "Beijing" });

            Assert.Equal(8630100 + 20693000, total);
        }
    }
}