public class Solution {
     public int[] NextGreaterElements(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        Stack<int> s = new Stack<int>();

        // Initialize result array with -1
        Array.Fill(res, -1);

        // Traverse twice (simulate circular array)
        for (int i = 2 * n - 1; i >= 0; i--) {
            while (s.Count > 0 && s.Peek() <= nums[i % n]) {
                s.Pop();
            }
            if (i < n) {
                res[i] = s.Count > 0 ? s.Peek() : -1;
            }
            s.Push(nums[i % n]);
        }

        return res;
    }
}
