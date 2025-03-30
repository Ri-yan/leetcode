public class Solution {
    public int NumberOfSubstrings(string s) {
        int count = 0;
        int[] hash = new int[3]; 
        Array.Fill(hash, -1);

        for (int i = 0; i < s.Length; i++) {
            hash[s[i] - 'a'] = i; // Update last seen index of 'a', 'b', or 'c'
            
            // Ensure all three characters have been seen
            if (hash[0] != -1 && hash[1] != -1 && hash[2] != -1) { 
                count += 1 + Math.Min(hash[0], Math.Min(hash[1], hash[2]));
            }
        }

        return count;
    }
}
