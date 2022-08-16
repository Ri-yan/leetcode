class Solution {
    public int firstUniqChar(String s) {
       if (s == null || s.length() == 0) {
            return -1;
        }
        if(s.length()==1){
            return 0;
        }
        int[] hash = new int[26];
        for(int i=0;i<s.length();i++){
            hash[s.charAt(i)-'a']++;
        }
        for(int i=0;i<s.length();i++){
            if(hash[s.charAt(i)-'a']==1)return i;
        }
        return -1;
    }
}