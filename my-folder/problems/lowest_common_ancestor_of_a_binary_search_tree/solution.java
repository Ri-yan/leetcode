/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */

class Solution {
    public TreeNode lowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
       TreeNode n=root;
        while(n!=null){
            if(p.val>n.val && q.val>n.val){
                n=n.right;
            }else if(p.val< n.val && q.val<n.val){
                n=n.left;
            }else return n;
        }
        return null;
    }
}