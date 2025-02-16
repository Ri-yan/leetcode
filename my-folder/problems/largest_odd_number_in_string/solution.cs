public class Solution {
    public string LargestOddNumber(string num) {
        if(num.Length<1){
            return "";
        }
        for (int i = num.Length - 1; i >= 0; i--) {
            // In C#, (num[i] - '0') is a common trick to convert a char representing a digit (like '0', '1', ..., '9') to its corresponding integer value.
            
            if ((num[i] - '0') % 2 != 0) {
                // Return the substring from 0 to i (inclusive)
                return num.Substring(0, i + 1);
            }
        }
        return "";
    }
}