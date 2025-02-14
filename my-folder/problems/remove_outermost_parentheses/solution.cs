public class Solution {
    public string RemoveOuterParentheses(string s) {
        var result = new List<char>();
        int c = 0;
        
        foreach (char ch in s) {
            if (ch == '(') {
                if (c > 0) {
                    result.Add('(');
                }
                c++;
            } else if (ch == ')') {
                c--;
                if (c > 0) {
                    result.Add(')');
                }
            }
        }
        
        return new string(result.ToArray());
    }
}