public class Solution {
    public static int recSearch(int[] nums, int low,int high,int target){
        if(low>high)return -1;
        int mid=(low+high)/2;
        if(target==nums[mid]) return mid;

        if(nums[mid]>target) return recSearch(nums,low,mid-1,target);
        else  return recSearch(nums,mid+1,high,target);
    }
    public int Search(int[] nums, int target) {
        return recSearch(nums, 0,nums.Length-1,target);
    }
}