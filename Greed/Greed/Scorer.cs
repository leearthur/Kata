namespace Greed
{
    public class Scorer
    {
        public static int CalculateScore(IEnumerable<int> dice) => dice
            .GroupBy(x => x)
            .Sum(x => (x.Count() >= 3 ? x.Key == 1 ? 1000 : x.Key * 100 : 0) +   // Tripples
                       x.Count() % 3 * (x.Key == 1 ? 100 : x.Key == 5 ? 50 : 0)  // Singles
            );
    }
}