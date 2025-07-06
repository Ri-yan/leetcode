public class Solution {
    public string FrequencySort(string s) {
        // Step 1: Count frequencies
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in s) {
            if (!freq.ContainsKey(c)) {
                freq[c] = 0;
            }
            freq[c]++;
        }

        // Step 2: Sort characters by frequency in descending order
        var sorted = freq.OrderByDescending(kvp => kvp.Value);

        // Step 3: Build result string
        StringBuilder sb = new StringBuilder();
        foreach (var kvp in sorted) {
            sb.Append(new string(kvp.Key, kvp.Value));
        }

        return sb.ToString();
    }
}
