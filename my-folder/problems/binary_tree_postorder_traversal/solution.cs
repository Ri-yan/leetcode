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
    public IList<int> PostorderTraversal(TreeNode root) {
        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();
        IList<int> ans = new List<int>();
        if(root==null){
            return ans;
        }
        s1.Push(root);
        while(s1.Count>0){
            var node = s1.Pop();
            s2.Push(node);
            if(node.left!=null){
                s1.Push(node.left);
            }
            if(node.right!=null){
                s1.Push(node.right);
            }
        }
        while(s2.Count>0){
            var node = s2.Pop();
            ans.Add(node.val);
        }
        return ans;
    }
}