public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int c=0;
        int c2=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==1){c++;if(c>c2)c2=c;}
            else c=0;
        }
        return c2;
    }
}