using Xunit;

namespace ZombieSurvivorKata.Tests.SurvivorTests
{
    public class IsDead
    {
        [Fact]
        public void StartsFalse()
        {
            Survivor survivor = new Survivor();

            Assert.False(survivor.IsDead);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void IsFalseForFewerThan2Wounds(int wounds)
        {
            Survivor survivor = new Survivor();

            survivor.Wounds = wounds;

            Assert.False(survivor.IsDead);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(10)]
        public void IsTrueAt2OrMoreWounds(int wounds)
        {
            Survivor survivor = new Survivor();

            survivor.Wounds = wounds;

            Assert.True(survivor.IsDead);
        }
    }
}
