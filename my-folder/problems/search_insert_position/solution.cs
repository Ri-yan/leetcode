public class Solution {
    public static int binarySearch(int[] nums,int low,int high, int target){
        if(low>high) return target;
        int mid = (low+high)/2;
        if(target==nums[mid]) return mid;
        if(target<=nums[mid]){
            return binarySearch(nums,low,mid-1, target);
        }else{
             return binarySearch(nums,mid+1,high, target);
        }
    }
    public int SearchInsert(int[] nums, int target) {
       int low=0;
       int high=nums.Length-1;
       int ans=nums.Length;
       while(low<=high){
        int mid=(low+high)/2;
        if(nums[mid]>=target){
            ans = mid;
            high = mid-1;
        }else{
            low = mid+1;
        }
       }
      return ans;
    }
}