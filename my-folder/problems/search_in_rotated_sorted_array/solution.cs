public class Solution {
    public int Search(int[] nums, int target) {
        int l=0;
        int h=nums.Length-1;
        int a =-1;
        while(l<=h){
            int m = (l+h)/2;
           if(nums[m]==target) a=m;
           if(nums[l]<=nums[m]){
            if(target<=nums[m] && nums[l]<=target) h=m-1;
            else l=m+1;
           }else{
           if(target>=nums[m] && target<=nums[h]) l=m+1;
            else h=m-1;
           }
        }
        return a;
    }
}