class Solution {
    public int lengthOfLastWord(String s) {
       // int count=0;
        s=s.trim();
        // for(int i=s.length()-1;i>=0;i--){
        //     if(s.charAt(i)==' ')
        //         count++;
        // }
        int i=0;
        for(i=s.length()-1;i>=0;i--){
            if(s.charAt(i)==' ')
            break;
        }
       i+=2;
        // System.out.println("i "+i);
        // System.out.println("l "+s.length());
        // System.out.println("count "+count);
        
        return (s.length()-i)+1;
    }
}