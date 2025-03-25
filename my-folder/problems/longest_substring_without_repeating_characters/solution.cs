public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max=0;
        // int[] map  = new int[256];
        // for(int i=0;i<s.Length;i++){
        //     Array.Fill(map,0);
        //     for(int j=i;j<s.Length;j++){
        //         char c = s[j];
        //         if (map[(int)c] > 0) {
        //             break;
        //         } else {
        //             map[(int)c] = 1;
        //         }
        //                     max = Math.Max(max,j-i+1);
        //     }
        // }
        // return max;

        Dictionary<char,int> map = new Dictionary<char,int>();
        int l=0;
        for(int r=0;r<s.Length;r++){
           if (map.ContainsKey(s[r]) && map[s[r]] >= l) {
                l = map[s[r]] + 1;
            }
            map[s[r]] = r;
            max =Math.Max(max,r-l+1);
        }
        return max;
    }
}