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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
      var q = new Queue<(TreeNode node, int row, int col)>();
        // col -> row -> List of values
        var map = new SortedDictionary<int, SortedDictionary<int, List<int>>>();

        q.Enqueue((root, 0, 0));

        while (q.Count > 0)
        {
            var (node, row, col) = q.Dequeue();

            if (!map.ContainsKey(col))
                map[col] = new SortedDictionary<int, List<int>>();

            if (!map[col].ContainsKey(row))
                map[col][row] = new List<int>();

            map[col][row].Add(node.val);

            if (node.left != null)
                q.Enqueue((node.left, row + 1, col - 1));
            if (node.right != null)
                q.Enqueue((node.right, row + 1, col + 1));
        }

        var result = new List<IList<int>>();
        foreach (var col in map.Values)
        {
            var vertical = new List<int>();
            foreach (var rowList in col.Values)
            {
                rowList.Sort(); // Sort values at the same row and col
                vertical.AddRange(rowList);
            }
            result.Add(vertical);
        }

        return result;
    }
}