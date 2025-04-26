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
        if(root == null ||  root==p ||  root==q){
            return root;
        }
        TreeNode lh = LowestCommonAncestor(root.left,p,q);
        TreeNode rh = LowestCommonAncestor(root.right,p,q);
        if(lh==null){
            return rh;
        }
        if(rh==null){
            return lh;
        }
        return root;
    }
}