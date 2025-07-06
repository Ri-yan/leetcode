public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";

        int min = strs[0].Length;
        foreach (var s in strs)
            min = Math.Min(min, s.Length);

        for (int c = min; c >= 0; c--) {
            string prefix = strs[0].Substring(0, c);
            bool isCommon = true;
            for (int i = 1; i < strs.Length; i++) {
                if (!strs[i].StartsWith(prefix)) {
                    isCommon = false;
                    break;
                }
            }
            if (isCommon) return prefix;
        }

        return "";
    }
}
