/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public  static int FindDiameter(TreeNode root,ref int max) {
        if(root==null){
            return 0;
        }
        int lh = FindDiameter( root.left, ref max);
        int rh = FindDiameter( root.right, ref max);
        max = Math.Max(max,lh+rh);
        return 1 + Math.Max(lh,rh);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        int max = -1;
        FindDiameter(root,ref max);
        return max;
    }
}