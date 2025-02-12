public class Solution {
    public bool Search(int[] nums, int target) {
        int l=0;
        int h=nums.Length-1;
        while(l<=h){
            int m=(l+h)/2;
            if(nums[m]==target) return true;
            if(nums[m]==nums[l] && nums[m]==nums[h]) {
                h--;
                l++;
                continue;
            }
            if(nums[l]<=nums[m]){
                if(target>=nums[l] && target <=nums[m]) h=m-1;
                else l=m+1;
            }else{
                if(target>=nums[m] && target <=nums[h]) l=m+1;
                else h=m-1;
            }
            
        }
        return false;
    }
}