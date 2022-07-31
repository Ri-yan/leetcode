class Solution {
    int j= 0;
    public int searchInsert(int[] nums, int target) {
       if(nums.length==0){
           return -1;
       }
        if(nums.length==1 && nums[0]==target){
           return 0;
       }
       int pos=0; 
        for(int i=0;i<=nums.length-1;i++){
           if(nums[i]==target){
               return i;
           }
            if(nums[i]<target)
                pos=i+1;
            else if(target<nums[i] && i==0){
                pos=0;
            }
            else if(i==nums.length-1 && target>nums[i])
                pos=i+1;
        }
        return pos;
    }
}