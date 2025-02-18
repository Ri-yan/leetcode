using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public string FrequencySort(string s) {
        // Create a dictionary to store character frequencies
        Dictionary<char, int> cnt = new Dictionary<char, int>();

        // Count the frequency of each character
        for (int i = 0; i < s.Length; i++) {
            if (cnt.ContainsKey(s[i])) {
                cnt[s[i]]++;
            } else {
                cnt[s[i]] = 1;
            }
        }

        // Create a list of characters from the dictionary keys
        List<char> cs = cnt.Keys.ToList();
        
        // Sort the characters by frequency in descending order
        cs.Sort((a, b) => cnt[b] - cnt[a]);

        // Build the result string
        StringBuilder ans = new StringBuilder();
        foreach (char c in cs) {
            for (int v = cnt[c]; v > 0; v--) {
                ans.Append(c);
            }
        }

        return ans.ToString();
    }
}
