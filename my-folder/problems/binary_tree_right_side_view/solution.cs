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
    public IList<int> RightSideView(TreeNode root) {
                var r = new List<int>();

        if(root==null) return r;
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> ans = new List<List<int>>();
        q.Enqueue(root);
        while(q.Count>0){
            int size = q.Count();
            // Create a list to store
            // nodes at the current level
            List<int> level = new  List<int>();

            for (int i = 0; i < size; i++) {
                // Get the front node in the queue
                var node=q.Dequeue();
                // Store the node value
                // in the current level list
                level.Add(node.val);
if (i == size - 1) {
                    r.Add(node.val);
                }

                // Enqueue the child nodes if they exist
                if (node.left != null) {
                    q.Enqueue(node.left);
                }
                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }
            // Store the current level
            // in the answer list
            ans.Add(level);
             
        }
        // foreach(var p in ans){
        //     r.Add(p[p.Count-1]);
        // }
        return r;
    }
}