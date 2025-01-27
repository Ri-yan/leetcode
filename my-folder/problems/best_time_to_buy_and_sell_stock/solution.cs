public class Solution {
    public int MaxProfit(int[] prices) {
    int maxPro = 0;
    int minPrice = prices[0];
    for (int i = 0; i < prices.Length; i++) {
        minPrice = Math.Min(minPrice, prices[i]);
        maxPro = Math.Max(maxPro, prices[i] - minPrice);
    }
    return maxPro;
    }
}