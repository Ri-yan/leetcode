class Solution {
    public boolean isPalindrome(int x) {
        if(x<0) return false;
        int temp=x;
        int re=0;
        while(temp>0){
            re=re*10+temp%10;
            temp/=10;
        }
        return re==x;
    }
}