class Solution {
    public void moveZeroes(int[] nums) {
        if(nums.length!=0||nums.length!=1){
         int i=0;
         int j=0;
        while(j<=nums.length-1){
            if(nums[j]==0 ){
                j++;
            }else{
                int temp=nums[j];
                nums[j]=nums[i];
                nums[i]=temp;
                i++;
                j++;
            }
        }
    } 
    }
}