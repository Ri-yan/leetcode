public class Solution {
    public bool IsBalanced(TreeNode root) {
        return GetHeight(root) != -1;
    }

    private int GetHeight(TreeNode node) {
        if (node == null) return 0;

        int left = GetHeight(node.left);
        if (left == -1) return -1; // Left subtree is not balanced

        int right = GetHeight(node.right);
        if (right == -1) return -1; // Right subtree is not balanced

        if (Math.Abs(left - right) > 1) return -1; // Current node is unbalanced

        return Math.Max(left, right) + 1;
    }
}
