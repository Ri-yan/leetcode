public class Solution {
    public int FindMin(int[] nums) {
        int l=0;
        int h=nums.Length-1;
        int min=int.MaxValue;
        while(l<=h){
            int m =(l+h)/2;
            
            min=Math.Min(nums[m],min);
            if(nums[l]==nums[m] && nums[h]==nums[m]){
                l++;
                h--;
                continue;
            }
            if(nums[l]<=nums[m]){
                min=Math.Min(nums[l],min);
                 l=m+1;
            }else{
                 min=Math.Min(nums[m],min);
                  h=m-1;
            }
        }
        return min;
    }
}