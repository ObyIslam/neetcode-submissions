public class Solution {
    public int Jump(int[] nums) {
        
        int jumps = 0;
        int currentEnd = 0;
        int maxReach = 0;

        for(int i = 0; i < nums.Length - 1; i++){

            maxReach = Math.Max(maxReach, nums[i] + i);

            if(i == currentEnd){
                jumps++;
                currentEnd = maxReach;
            }
        }

        return jumps;
    }
}
