public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        Dictionary<char, int> hash = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (hash.ContainsKey(s[i])) {
                hash[s[i]] = hash[s[i]] + 1;
            } else {
                hash.Add(s[i], 1);
            }
        }

        for (int i = 0; i < t.Length; i++) {
            if (hash.ContainsKey(t[i])) {
                hash[t[i]] = hash[t[i]] - 1;
            } else {
                return false;
            }
        }

        foreach (var h in hash) {
            if (h.Value != 0) {
                return false;
            }
        }

        return true;
    }
}
