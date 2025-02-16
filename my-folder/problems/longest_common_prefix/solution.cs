public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         if (strs == null || strs.Length == 0) return "";
        string result="";
        int min = strs[0].Length;

        for(int i=0;i<strs.Length;i++){
            min = Math.Min(min,strs[i].Length);
        }
        
        for(int c=min;c>=0;c--){
            string d = strs[0].Substring(0,c); 
            int t=0;
            for(int i=0;i<strs.Length;i++){
                if(d==strs[i].Substring(0,c)){
                
                if(t==strs.Length-1) return d;t++;
                }else{
                result= "";
                }
            }
        }
        return result;
    }
}