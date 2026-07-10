public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] results = new int [nums.Length];

    
        for(int i = 0; i < nums.Length; i++){
            
            int total = 1;
            for(int j= 0; j < nums.Length; j++){

                if(i != j){
                    total *= nums[j];
                }
            }

            results[i] = total;
            
        }
        return results;

    }
}
