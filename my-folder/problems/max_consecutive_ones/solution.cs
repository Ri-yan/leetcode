public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int c=0;
        int max =0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==1) c++;
            if(nums[i]==0){
                max=Math.Max(c,max);
                c=0;
            }
        }
        max=Math.Max(c,max);
        return max;
    }
}