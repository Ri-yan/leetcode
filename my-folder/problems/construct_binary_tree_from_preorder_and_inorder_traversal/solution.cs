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
    public TreeNode BuildTree(int[] preorder,int spre,int epre, int[] inorder,int sin,int ein,Dictionary<int,int> map) {
        if(spre>epre || sin>ein){
            return null;
        }
        var root = new TreeNode(){val=preorder[spre]};
        int inroot = map[preorder[spre]];
        int numleft = inroot-sin;
        root.left = BuildTree(preorder,spre+1,spre + numleft,inorder,sin,inroot-1,map);
        root.right = BuildTree(preorder,spre + numleft+1,epre + numleft,inorder,inroot+1,ein,map);
        return root;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<inorder.Length;i++){
            map.Add(inorder[i],i);
        }
        return BuildTree(preorder,0,preorder.Length-1,inorder,0,inorder.Length-1,map);
    }
}