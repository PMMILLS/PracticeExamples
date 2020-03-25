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
                // counts how many times coins[i] can go into V
                count += V / coins[i];

                // subtracts coins[i] multiplied by how many times it goes into V
                V = V - (coins[i] * (V / coins[i]));

                if (V == 0)
                    return count;
            }

            return -1;
        }
    }
}
