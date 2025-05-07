public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null)  return "";

        var result = "";
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0) {
            int size = q.Count;
            for (int i = 0; i < size; i++) {
                var node = q.Dequeue();
                if (node != null) {
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                    result += node.val.ToString()+",";  // Append the node value
                }else {
                   result += "#,";  
                }
            }
        }
        if (result.Length > 0)   result = result.TrimEnd(',');
        return result;
    }

   
   public TreeNode deserialize(string data) {
    if (string.IsNullOrEmpty(data)) return null; 

    if (data.Length==1) return new TreeNode(int.Parse(data));
   
    string[] nodes = data.Split(',');
    TreeNode root = new TreeNode(int.Parse(nodes[0]));
    Queue<TreeNode> q = new Queue<TreeNode>();
    q.Enqueue(root);
    int p = 1;
    while (q.Count > 0 && p < nodes.Length) {
        TreeNode node = q.Dequeue();

        // Left child
        if (p < nodes.Length && nodes[p] != "#") {
            node.left = new TreeNode(int.Parse(nodes[p]));
            q.Enqueue(node.left);
        }
        p++;

        // Right child
        if (p < nodes.Length && nodes[p] != "#") {
            node.right = new TreeNode(int.Parse(nodes[p]));
            q.Enqueue(node.right);
        }
        p++;
    }

    return root;
}

}
