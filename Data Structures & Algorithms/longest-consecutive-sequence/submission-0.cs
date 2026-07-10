public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> numSet = new (nums);

        int longest = 0;

        foreach(int num in numSet){

            //only start
            if(!numSet.Contains(num - 1)){
                int length = 1;

                //copunt numbers after num
                while(numSet.Contains(num + length)){
                    length++;
                }

                //update longest sequence
                longest = Math.Max(longest,length);
            }
        }

        return longest;
    }
}
