class Solution {
    public int removeElement(int[] nums, int val) {
        if(nums.length==0){
            return 0;
        }
        int count=0;
        for(int i=0;i<=nums.length-1;i++){
           if(nums[i]!=val){
               nums[count++]=nums[i];
               continue;
           }
        }
        return count;
    }
}