public class Solution {
    public string ReverseWords(string s) {
       var arr = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(arr);
        return string.Join(" ", arr);
    }
}