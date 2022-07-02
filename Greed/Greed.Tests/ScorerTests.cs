namespace Greed.Tests
{
    public class ScorerTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 5, 1 }, 1150)]     
        [InlineData(new[] { 2, 3, 4, 6, 2 }, 0)]
        [InlineData(new[] { 3, 4, 5, 3, 3 }, 350)]       
        public void ExampleTests(int[] dice, int expectedScore)
        {
            Assert.Equal(expectedScore, Scorer.CalculateScore(dice));
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 2, 3 }, 1000)]
        [InlineData(new[] { 2, 2, 2, 3, 4 }, 200)]
        [InlineData(new[] { 3, 3, 3, 2, 4 }, 300)]
        [InlineData(new[] { 4, 4, 4, 2, 6 }, 400)]
        [InlineData(new[] { 5, 5, 5, 2, 6 }, 500)]
        [InlineData(new[] { 6, 6, 6, 2, 3 }, 600)]
        public void TripletTests(int[] dice, int expectedScore)
        {
            Assert.Equal(expectedScore, Scorer.CalculateScore(dice));
        }

        [Theory]
        [InlineData(new[] { 1, 3, 4, 6, 2 }, 100)]
        [InlineData(new[] { 5, 3, 4, 6, 2 }, 50)]
        public void SingleTests(int[] dice, int expectedScore)
        {
            Assert.Equal(expectedScore, Scorer.CalculateScore(dice));
        }


        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 1200)]
        [InlineData(new[] { 5, 5, 5, 5, 5 }, 600)]
        public void EdgeCases(int[] dice, int expectedScore)
        {
            Assert.Equal(expectedScore, Scorer.CalculateScore(dice));
        }
    }
}