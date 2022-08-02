class Solution {
    public int[] sortedSquares(int[] nums) {
        if(nums.length==0)
            return nums;
        if(nums.length==1){
            nums[0]=(nums[0]*nums[0]);
            return nums;
        }
        for(int i=0;i<=nums.length-1;i++){
            nums[i]=(nums[i]*nums[i]);
        }
        Arrays.sort(nums);
        return nums;
    }
}