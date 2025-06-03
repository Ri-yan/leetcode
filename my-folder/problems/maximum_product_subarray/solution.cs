public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        int max = int.MinValue;
        int pre = 1;
        int suff = 1;
        int p =1;
        for(int i=0;i<nums.Length;i++){
            suff *=nums[i];
            pre *= nums[nums.Length-i-1]; 
            max = Math.Max(max,Math.Max(pre,suff));

            if (pre == 0) pre = 1;
            if (suff == 0) suff = 1;
        }
        return max;
    }
}
// public class Solution {
//     public int MaxProduct(int[] nums) {
//         if (nums == null || nums.Length == 0) return 0;

//         int max = nums[0];
//         int pre = 1;
//         int suff = 1;
//         int n = nums.Length;

//         for (int i = 0; i < n; i++) {
//             pre = (pre == 0 ? 1 : pre) * nums[i];
//             suff = (suff == 0 ? 1 : suff) * nums[n - 1 - i];
//             max = Math.Max(max, Math.Max(pre, suff));
//         }

//         return max;
//     }
// }
