public class Solution {
    public void MoveZeroes(int[] nums) {
        int p=0;
        for(int i=0;i<=nums.Length-1;i++){
            if(nums[i]!=0){
                (nums[i],nums[p])=(nums[p],nums[i]);
                p++;
            }
        }
    }
}