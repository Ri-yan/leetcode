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
    public TreeNode BuildTree(int[] inorder,int si,int ei, int[] postorder,int sp, int ep, Dictionary<int,int> map) {
        if(si>ei || sp>ep){
            return null;
        }
       var root = new TreeNode() { val = postorder[ep] };
        int inRoot = map[root.val];
        int numLeft = inRoot-si;
         root.left = BuildTree(inorder, si, inRoot-1, postorder, sp, sp + numLeft - 1, map);
         root.right =BuildTree(inorder, inRoot+1, ei,  postorder,  sp + numLeft, ep - 1, map);
        return root;
    }
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
      /*
      inorder = [9,3,15,20,7], LOR
      postorder = [9,15,7,20,3], LRO
      */  
      Dictionary<int,int> map = new Dictionary<int,int>();

      for(int i=0;i<inorder.Length;i++){
        map.Add(inorder[i],i);
      }
       return BuildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1, map);
    }
}