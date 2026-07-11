public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> seen = new();

        int left = 0;
        int longest = 0;

        for(int right = 0; right < s.Length; right++){

            while(seen.Contains(s[right])){
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(s[right]);
            longest = Math.Max(longest, right - left + 1);
        }
        return longest;
    }
}
