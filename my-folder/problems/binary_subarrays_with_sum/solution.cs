public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int n = nums.Length;
        int count =0;
        for (int i = 0; i < n; i++) {
            int sum = 0;
            for (int j = i; j < n; j++) {
                sum += nums[j];  // Add the current element to the sum
                if (sum == goal) {  // If the sum matches the goal
                    count++;
                }
            }
        }
        return count;
    }
}