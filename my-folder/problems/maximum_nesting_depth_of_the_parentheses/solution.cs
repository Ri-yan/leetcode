public class Solution {
    public int MaxDepth(string s) {
        int max=0;
        int c =0;
        foreach(char i in s){
            if(i=='('){ c++; max = Math.Max(c,max);}
            else if(i==')') c--;
        }
        max = Math.Max(c,max);
        return max;
    }
}