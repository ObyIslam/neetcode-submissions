public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char, int> seen1 = new ();
        Dictionary<char, int> seen2 = new ();

        if(s.Length != t.Length){
            return false;
        }


        foreach (char c in s){
            if(seen1.ContainsKey(c)){
                seen1[c]++;
            }
            else {
                seen1[c] = 1;
            }
        }

        foreach (char c in t){
            if(seen2.ContainsKey(c)){
                seen2[c]++;
            }
            else {
                seen2[c] = 1;
            }
        }

        foreach(var item in seen1){
            if(!seen2.ContainsKey(item.Key) || seen2[item.Key] != item.Value){
                return false;
            }
        }

        return true;
    }
}
