public class Solution {
    public int HelperNumSubarraysWithSum(int[] nums, int goal) {
        if(goal<0) return 0;
        int l=0,r=0,c=0,sum=0;
        int n= nums.Length;
        while(r<n){
             sum=sum+nums[r];
             while(sum>goal){
                sum-=nums[l];
                l++;
             }
             c += r-l+1;
            r++;
        }
       
        return c;
    }
    public int NumSubarraysWithSum(int[] nums, int goal) {
        if(goal<0) return 0;
       return HelperNumSubarraysWithSum(nums,goal)-HelperNumSubarraysWithSum(nums,goal-1);
    }
}