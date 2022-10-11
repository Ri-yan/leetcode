class Solution {
    public int romanToInt(String s) {
        int result = 0;
        int num[] = new int[s.length()];
        for(int i=0;i<s.length();i++){
        switch (s.charAt(i)){
               case 'I':num[i]=1;
                   break;
                case 'V':num[i]=5;
                   break;
                case 'X':num[i]=10;
                   break;
               case 'L':num[i]=50;
                   break;
               case 'C':num[i]=100;
                   break;
               case 'D':num[i]=500;
                   break;
                case 'M':num[i]=1000;
                   break;
           }
       }
        for(int i=0;i<num.length-1;i++){
            if(num[i]<num[i+1]){
                result-=num[i];
            }else{
                 result+=num[i];
            }
        }

    return result+num[num.length-1];
        
    }
   
}
   