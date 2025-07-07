public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length) return false;
        Dictionary<char,char> map1 = new Dictionary<char,char>();
        Dictionary<char,char> map2 = new Dictionary<char,char>();

        for(int i=0;i<s.Length;i++){
             char c1 = s[i];
            char c2 = t[i];
              if (map1.ContainsKey(c1)) {
                if (map1[c1] != c2) return false;
            } else {
                if (map2.ContainsKey(c2)) return false; // reverse mapping conflict
                map1[c1] = c2;
                map2[c2] = c1;
            }
        }
        return true;
    }
}