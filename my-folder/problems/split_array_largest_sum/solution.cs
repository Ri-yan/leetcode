public class Solution {
    public bool findMaxSumArray(int[] nums, int k, int mid){
        int c=1;int s=0;
        int max = 0;
        for(int i=0;i<nums.Length;i++){
            if(c>k){
                return false;
            }
            if(s+nums[i]<=mid){
                s+=nums[i];
            }else{
                c++;
                s=nums[i];
                if(c>k) return false;
            }
            
        }
        
        return true;
    }
    public int SplitArray(int[] nums, int k) {
      int min = nums.Max();
      int max = nums.Sum();
      int ans = -1;
      while(min<=max){
        int mid = (min+max)/2;
        if(findMaxSumArray(nums, k, mid)){
            max = mid-1;
            ans = mid;
        }else{
            min = mid+1;
        }
      }
      return ans;
    }
}