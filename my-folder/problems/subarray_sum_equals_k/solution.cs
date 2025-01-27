public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int n =nums.Length;
        int c=0;
        for(int i=0;i<n;i++){
            int sum=0;
            for(int j=i;j<n;j++){
                sum+=nums[j];
                if(sum==k){
                    c++;
                }
            }
        }
        return c;
    }
}