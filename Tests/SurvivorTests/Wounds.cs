using Xunit;

namespace ZombieSurvivorKata.Tests.SurvivorTests
{
    public class Wounds
    {
        [Fact]
        public void StartAt0()
        {
            Survivor survivor = new Survivor();

            Assert.Equal(0, survivor.Wounds);
        }
    }
}
