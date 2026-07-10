public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> seen = new();

        
        for(int i = 0; i < nums.Length; i++){

            int neededNum = target - nums[i];

            if(seen.ContainsKey(neededNum)){
                return new int[] {seen[neededNum], i};
            }

            seen[nums[i]] = i;
        }
        return Array.Empty<int>();

        

    }
}
