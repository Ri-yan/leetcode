public class Solution {
int Calculate(int[] nums, int divisor) {
    int n = nums.Length;
    int s = 0;
    for (int i = 0; i < n; i++) {
        s += (int)Math.Ceiling((double)nums[i] / divisor);
    }
    return s;
}

    public int SmallestDivisor(int[] nums, int threshold) {
        int n=nums.Length;
        int h=nums.Max();
        int l=1;
        int ans =-1;
        while(l<=h){
            int m = (l+h)/2;
            if(Calculate(nums,m)<=threshold){
                ans=m;
                h=m-1;
            }else{
                l=m+1;
            }
        }
        return ans;
    }
}