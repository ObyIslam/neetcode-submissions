public class Solution {
    public int MaxProfit(int[] prices) {
        
        int lowestPrice = prices[0];
        int maxProfit = 0;

        for(int i = 0; i < prices.Length; i++){

            if(prices[i] < lowestPrice){
                lowestPrice = prices[i];
            }
            else{
                int profit = prices[i] - lowestPrice;

                maxProfit = Math.Max(profit, maxProfit);
            }


        }

        return maxProfit;


    }
}
