public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        // Create a dictionary:
        // Key = sorted version of the word (example: "aet")
        // Value = list of words that belong to that group
        Dictionary<string, List<string>> groups = new ();

        // Loop through every word in strs
        foreach (string word in strs){
            // Convert the current word into a character array
            char[] chars = word.ToCharArray();

            // Sort the characters alphabetically
            Array.Sort(chars);

            // Convert the sorted characters back into a string
            string key = new string(chars);
            // This will be your dictionary key

            // If this key does not exist in the dictionary:
            if(!groups.ContainsKey(key)){
                groups[key] = new List<string>();
            }
  

            // Add the original word to the list for this key
            groups[key].Add(word);

        }

        // Return all the grouped lists from the dictionary
        return groups.Values.ToList();

    }
}