public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (num.Length == k) return "0";
        Stack<char> s = new Stack<char>();
        for(int i=0;i<num.Length;i++){
            while(s.Count>0 && (s.Peek()-'0')>(num[i]-'0') && k>0){
                s.Pop();
                k--;
            }
            s.Push(num[i]);
        }
        StringBuilder res = new StringBuilder();
       
         while (k > 0 && s.Count > 0) {
            s.Pop();
            k--;
        }
         while (s.Count > 0) {
            res.Append(s.Pop());
        }
        // Reverse correctly
        string result = new string(res.ToString().Reverse().ToArray());

        // Remove leading zeros
        result = result.TrimStart('0');

        return result.Length == 0 ? "0" : result;
    }
}