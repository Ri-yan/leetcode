public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
    int o = m - 1; // Start from the end of nums1's valid elements
    int p = n - 1; // Start from the end of nums2
    int i = m + n - 1; // Index to place the next largest element

    // Merge the arrays from the back
    while (o >= 0 && p >= 0) {
        if (nums1[o] > nums2[p]) {
            nums1[i] = nums1[o];
            o--;
        } else {
            nums1[i] = nums2[p];
            p--;
        }
        i--;
    }

    // If there are remaining elements in nums2, copy them over
    while (p >= 0) {
        nums1[i] = nums2[p];
        p--;
        i--;
    }
    }
}