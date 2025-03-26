public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int m =0;
        int l=0;
        int r=0;
        int n=nums.Length;
        int z =0;
        while(r<n){
            if(nums[r]==0) z++;
            if(z>k){
                if(nums[l]==0)z--;
                l++;
            }
            if(z<=k)
            m=Math.Max(m,r-l+1);
            r++;
        }
        return m;
    }
}