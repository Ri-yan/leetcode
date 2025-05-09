/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null) return null;
        int c=root.val;
        if(c<p.val && c<q.val) return LowestCommonAncestor(root.right, p, q);
        if(c>p.val && c>q.val) return LowestCommonAncestor(root.left, p, q);
        return root;
    }
}