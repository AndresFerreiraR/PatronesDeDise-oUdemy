using SingletonPattern.Classes;
using TestSingleton.MockTest;
using Xunit;

namespace TestSingleton
{
    public class SingletonFinderTest
    {
        [Fact]
        public void Test1()
        {
            var finder = new SingletonFinder(new DummyDataBase());
            var total = finder.GetTotalPopulation(new[] { "Santiago", "Buenos Aires" });

            Assert.Equal(7000 + 222, total);
        }
    }
}