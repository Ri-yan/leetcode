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
    public void traverse(TreeNode root ,ref int c){
        if(root==null){
            return;
        }
        c++;
        traverse(root.left,ref c);
        traverse(root.right,ref c);
    }
    public int CountNodes(TreeNode root) {
        int c=0;
        traverse(root ,ref c);
        return c;
    }
}