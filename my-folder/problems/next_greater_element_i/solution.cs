public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
      Stack<int> s = new Stack<int>();
        Dictionary<int, int> nextGreaterMap = new Dictionary<int, int>();

        // Traverse nums2 from right to left and find next greater elements
        for (int i = nums2.Length - 1; i >= 0; i--) {
            int num = nums2[i];

            // Maintain a decreasing stack
            while (s.Count > 0 && s.Peek() <= num) {
                s.Pop();
            }

            // Store the next greater element or -1 if none exists
            nextGreaterMap[num] = s.Count > 0 ? s.Peek() : -1;
            s.Push(num);
        }

        // Map results for nums1 using Array.ConvertAll for conciseness
        int[] res = new int[nums1.Length];
    for (int i = 0; i < nums1.Length; i++) {
        res[i] = nextGreaterMap[nums1[i]];
    }
    
    return res;
    }
}
