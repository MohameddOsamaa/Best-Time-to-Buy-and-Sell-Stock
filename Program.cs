public class Solution
{
    public static int MaxProfit()
    {
        int maxProfit = 0;
        int minPrice;
        int[] prices = { 7, 1, 5, 3, 6, 4 }; // { 2,4,1 }; { 7, 6, 4, 3, 1 } {2, 1, 2, 0, 1}

        minPrice = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            minPrice = prices[i] < minPrice ? prices[i] : minPrice;

            maxProfit = prices[i] - minPrice > maxProfit ? prices[i] - minPrice : maxProfit;
        }

        return maxProfit;
    }

    public static void Main()
    {
        Console.WriteLine(MaxProfit());
    }
}