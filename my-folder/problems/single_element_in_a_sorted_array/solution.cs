public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int n = nums.Length-1;
        if(nums.Length==1){
            return nums[0];
        }
        if(nums[0]!=nums[1]){
            return nums[0];
        }
         if(nums[n]!=nums[n-1]){
            return nums[n];
        }
        int l=1;
        int h=n-1;
        int ans=-1;
        while(l<=h){
            int m = (l+h)/2;
            if(nums[m]!=nums[m-1] && nums[m]!=nums[m+1]) return nums[m];
            if((m%2==1 && nums[m]==nums[m-1]) || (m%2==0 && nums[m]==nums[m+1])){
                l=m+1;
            }else{
               h=m-1; 
            }
        }
        return ans;
    }
}