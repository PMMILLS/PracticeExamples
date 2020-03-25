namespace PracticeExamples.Examples
{
    public class CoinChange
    {
        private int count;

        public CoinChange()
        {  
            count = 0; 
        }

        public int minCoins(int[] coins, int m, int V)
        {
            for (int i = m-1; i >= 0; i--)
            {
                count += V / coins[i];
                V = V - (coins[i] * (V / coins[i]));

                if (V == 0)
                    return count;
            }

            return -1;
        }
    }
}
