public class Solution {
    public string RemoveOuterParentheses(string s) {
        int c=0;
        string ans="";
        foreach (char ch in s) {
            if(ch=='(') {
               if (c > 0) ans += ch;
                c++;
            }else{
                c--;
                if(c>0)ans+=ch;
            }
        }
        return ans;
    }
}