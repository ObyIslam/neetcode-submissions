public class Solution 
{
    public bool CheckInclusion(string s1, string s2) 
    {
        Dictionary<char, int> need = new();

        // Count characters in s1
        foreach(char c in s1)
        {
            if(need.ContainsKey(c))
            {
                need[c]++;
            }
            else
            {
                need[c] = 1;
            }
        }

        Dictionary<char, int> window = new();

        int left = 0;

        for(int right = 0; right < s2.Length; right++)
        {
            // Add current character to window
            if(window.ContainsKey(s2[right]))
            {
                window[s2[right]]++;
            }
            else
            {
                window[s2[right]] = 1;
            }


            // Keep window size equal to s1
            while(right - left + 1 > s1.Length)
            {
                window[s2[left]]--;

                if(window[s2[left]] == 0)
                {
                    window.Remove(s2[left]);
                }

                left++;
            }


            // Check if current window is a permutation
            if(need.Count == window.Count)
            {
                bool match = true;

                foreach(var item in need)
                {
                    if(!window.ContainsKey(item.Key) || window[item.Key] != item.Value)
                    {
                        match = false;
                        break;
                    }
                }

                if(match)
                {
                    return true;
                }
            }
        }

        return false;
    }
}