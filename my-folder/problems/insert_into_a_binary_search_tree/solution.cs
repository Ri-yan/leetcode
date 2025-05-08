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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root==null) return new TreeNode(val);
        var temp = root;
        while(true){
            if(val<=temp.val){
                if(temp.left!=null){
                    temp=temp.left;
                }else{
                    temp.left = new TreeNode(val);
                    break;
                }
            }else{
               if(temp.right!=null){
                    temp=temp.right;
                }else{
                    temp.right = new TreeNode(val);
                     break;
                }
            }
        }
        return root;
    }
}