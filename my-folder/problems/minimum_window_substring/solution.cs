public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int r = 0, l = 0, c = 0, si = 0;
        int min = int.MaxValue;

        // Build frequency map for t
        for (int i = 0; i < t.Length; i++) {
            if (map.ContainsKey(t[i])) map[t[i]]++;
            else map[t[i]] = 1;
        }

        int minLength = map.Count;

        for (; r < s.Length; r++) {
            if (map.ContainsKey(s[r])) {
                map[s[r]]--;
                if (map[s[r]] == 0) c++;
            }

            // Try to shrink the window from the left while valid
            while (c == minLength) {
                if (r - l + 1 < min) {
                    min = r - l + 1;
                    si = l;
                }

                if (map.ContainsKey(s[l])) {
                    if (map[s[l]] == 0) c--;
                    map[s[l]]++;
                }

                l++;
            }
        }

        return min == int.MaxValue ? "" : s.Substring(si, min);
    }
}
