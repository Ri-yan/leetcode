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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if(root==null) return result;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        bool rev =false;
        while(q.Count>0){
              int levelSize = q.Count;
            var ans = new List<int>();

            for (int i = 0; i < levelSize; i++) {
                var node = q.Dequeue();

                // Insert depending on the level's direction
                if (rev) {
                    ans.Insert(0, node.val); // Add to front
                } else {
                    ans.Add(node.val); // Add to end
                }

                // Enqueue left first, then right
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            result.Add(ans);
            rev = !rev; // Flip direction for next level
        }
        return result;
    }
}