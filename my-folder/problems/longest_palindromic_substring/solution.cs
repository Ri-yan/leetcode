public class Solution {
    private static bool isPalindrom(string s, int i, int j) {
        while (i <= j) {
            if (s[i] != s[j]) return false;
            i++;
            j--;
        }
        return true;
    }

    public string LongestPalindrome(string s) {
        string ans = "";
        for (int i = 0; i < s.Length; i++) {
            for (int j = i; j < s.Length; j++) {
                if (isPalindrom(s, i, j)) {
                    int len = j - i + 1;
                    if (len > ans.Length) {
                        ans = s.Substring(i, len);
                    }
                }
            }
        }
        return ans;
    }
}
