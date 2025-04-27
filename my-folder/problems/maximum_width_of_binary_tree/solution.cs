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
    public int WidthOfBinaryTree(TreeNode root) {
        if(root==null)
        {
            return 0;
        }
        Queue<(TreeNode, int)> q = new Queue<(TreeNode, int)>();

        q.Enqueue((root,0));
        int mw = 0;
        while(q.Count>0){
            int size = q.Count;
            int r=0,l=0;
            var (n,min) = q.Peek();
            for(int i=0;i<size;i++){
                var (node,index) = q.Dequeue();
                index -= min; 
                if(i==0) l=index;
                if(i==size-1) r=index;
                if(node.right!=null){
                    int p = 2*index+1;
                    q.Enqueue((node.right,p));
                }
                if(node.left!=null){
                    int p = 2*index+2;
                    q.Enqueue((node.left,p));
                }
            }
            mw= Math.Max(mw,r-l+1);
        }
        return mw;
    }
}