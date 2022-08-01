class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {
        if(nums.length==0){
            return 0;
        }
        if(nums.length==1 && nums[0]==1){
            return 1;
        }
        int count=0;
        int maxcount=0;
        for(int i:nums){
            if(i==1){
                count++;
             if(count>=maxcount){
                    maxcount=count;
                }  
            }else if(i==0){
                if(count>=maxcount){
                    maxcount=count;
                }
                count=0;
            }
        }
        return maxcount;
    }
}