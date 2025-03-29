using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    static int FindMax(Dictionary<char, int> m) {
        return m.Values.Max();
    }

    public int CharacterReplacement(string s, int k) {
        int mf = 0; // Max frequency of any character in the current window
        int ml = 0; // Max length of valid window
        int l = 0, r = 0; // Sliding window pointers
        int n = s.Length;
        Dictionary<char, int> map = new Dictionary<char, int>();

        void MapAdd(char c) {
            if (!map.ContainsKey(c)) {
                map[c] = 1;
            } else {
                map[c]++;
            }
        }

        void MapRemove(char c) {
            if (map.ContainsKey(c)) {
                map[c]--;
                if (map[c] == 0) map.Remove(c); // Clean up map
            }
        }

        while (r < n) {
            MapAdd(s[r]);
            mf = FindMax(map);

            // Check if the current window is valid
            while ((r - l + 1) - mf > k) {
                MapRemove(s[l]);
                l++; // Shrink window from the left
                mf = FindMax(map);
            }

            ml = Math.Max(ml, r - l + 1); // Update max length
            r++;
        }

        return ml;
    }
}
