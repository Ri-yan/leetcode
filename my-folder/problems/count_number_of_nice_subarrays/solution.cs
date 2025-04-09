public class Solution {
    static int H_NumberOfSubarrays(int[] nums, int k) {
        int l=0,r=0,s=0,c=0,n=nums.Length;
        while(r<n){
            s+=nums[r]%2;
            while(s>k){
                s-=nums[l]%2;
                l++;
            }
            c=c+r-l-1;
            r++;
        }
        return c;
    }
    public int NumberOfSubarrays(int[] nums, int k) {
        if(k<0){
            return k;
        }
        return H_NumberOfSubarrays(nums,k) - H_NumberOfSubarrays(nums,k-1);
    }
}