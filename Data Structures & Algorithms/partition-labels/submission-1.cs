public class Solution {
    public List<int> PartitionLabels(string s) {
        
        Dictionary<char,int> last = new();

        for(int i = 0; i < s.Length; i++){
            last[s[i]] = i;
        }

        List<int> result = new();

        int start = 0;
        int end = 0;

        for(int i = 0; i < s.Length; i++){

            end = Math.Max(end , last[s[i]]);

            if(i == end){
                result.Add(i - start +1);
                start = i + 1;
            }
        }

        return result;

    }
}
