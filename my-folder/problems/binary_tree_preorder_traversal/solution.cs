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
    static void PreOrder(TreeNode root,IList<int> res){
        if(root==null){
            
            return ;
        }
        res.Add(root.val);
        PreOrder(root.left, res);
        PreOrder(root.right, res);

    }
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> res =  new List<int>();
        PreOrder(root, res);
        return res;
    }
}