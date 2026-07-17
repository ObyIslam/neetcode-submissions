public class Solution {
    public int FindDuplicate(int[] nums) {


        int slow = 0;
        int fast = 0;

        //find intersection point
        do{
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while(slow != fast);

        slow = 0;

        while(slow != fast){
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
        
    }
}
