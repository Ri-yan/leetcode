class Solution {
    public int findNumbers(int[] nums) {
        if(nums.length==0) return 0;
        
        int e=0;
        for(int i:nums){
            int count=0;
           while(i>0){
               count++;
               i/=10;
           }
            if(count%2==0){
                e++;
            }
        }
        return e;
    }
}