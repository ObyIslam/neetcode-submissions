public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> count = new();

        int left = 0;
        int maxFrequency = 0;
        int result = 0;

        for(int right = 0; right < s.Length; right++)
        {
            // Add current character to the window
            if(count.ContainsKey(s[right]))
            {
                count[s[right]]++;
            }
            else
            {
                count[s[right]] = 1;
            }

            // Keep track of the most common character in the window
            maxFrequency = Math.Max(maxFrequency, count[s[right]]);


            // If replacements needed are too many, shrink window
            while((right - left + 1) - maxFrequency > k)
            {
                count[s[left]]--;
                left++;
            }

            // Update longest valid window
            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}