public class Solution {
    public int SearchInsert(int[] nums, int target) {
      int l =0;
      int h=nums.Length-1;  
      int ans=nums.Length;
      while(l<=h){
        int m = (l+h)/2;
        if(nums[m]>=target){
            ans=m;
            h=m-1;
        }else{
            l=m+1;
        }
      }
      return ans;
    }
}