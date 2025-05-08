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
    public void KthSmallest2(TreeNode root, ref List<int> l) {
        if(root==null){
            return;
        }
         KthSmallest2(root.left, ref l);
        l.Add(root.val);
         KthSmallest2(root.right, ref l) ;
    }
    public int KthSmallest(TreeNode root, int k) {
        List<int> p = new List<int>();
        KthSmallest2(root, ref p);
        return p[k - 1];
    }
}