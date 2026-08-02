public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var bestBuyingPrice = prices[0];
        for (var i = 1; i < prices.Length; i++)
        {
            maxProfit = Math.Max(maxProfit, prices[i] - bestBuyingPrice);
            bestBuyingPrice =  Math.Min(prices[i], bestBuyingPrice);
        }

        return maxProfit;
    }
}
