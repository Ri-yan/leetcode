public class Solution {
    public bool RotateString(string s, string goal) {
         if(s.Length !=goal.Length){
            return false;
        }
        if((goal + goal).Contains(s)) return true;
        return false;
    }
}