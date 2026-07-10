public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> count = new ();

        for(int i = 0; i < nums.Length; i++){

            if(count.ContainsKey(nums[i])){
                count[nums[i]]++;
            }
            else{
                count[nums[i]] = 1;
            }
        }

        var sorted = count.OrderByDescending(x => x.Value).ToList();

        List<int> result = new();

        for(int i = 0; i < k; i++)
        {
            result.Add(sorted[i].Key);
        }

        return result.ToArray();
    }
}