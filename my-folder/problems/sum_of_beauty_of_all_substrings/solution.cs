public class Solution {   
    private static int CalculateBeauty(int[] freq) {
        int max = freq.Max();
        int min = int.MaxValue;
        foreach (var f in freq) {
            if (f > 0) min = Math.Min(min, f);
        }
        return max - min;
    }
    public int BeautySum(string s) {
    
        int maxBeauty=0;
         for (int i = 0; i < s.Length; i++) {
            var beautyArray = new int[26];
            for (int j = i ; j < s.Length; j++) {
               beautyArray[s[j]-'a']++;  
               var beauty = CalculateBeauty(beautyArray);
               maxBeauty+=beauty;
            }
            
               
        }
        return maxBeauty;
    }
}