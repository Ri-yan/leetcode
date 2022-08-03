class Solution {
    public int[] sortArrayByParity(int[] nums) {
        if(nums.length==0){
            return nums;
        } 
        if(nums.length==2 && nums[0]==0){
            return nums;
        } 
        if(nums.length==1){
            return nums;
        } 
        int count=0;
        for(int i=0;i<=nums.length-1;i++){
            if(nums[i]%2==0 && i<=nums.length-1){
                int temp=nums[count];
                nums[count]=nums[i];
                nums[i]=temp;
                count++;
            }
            
        }
        return nums;
    }
}