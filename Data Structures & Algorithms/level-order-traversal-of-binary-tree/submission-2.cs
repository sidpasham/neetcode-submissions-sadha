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
    public List<List<int>> LevelOrder(TreeNode root) {
        // edgecases
        List<List<int>> result = new List<List<int>>();
        if (root == null) {
            return result;
        }

        // level order traversal or BFS
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        // for each layer
        while (q.Count > 0) {
            // create array to store all nodes in that level
            List<int> curVals = new List<int>();

            var length = q.Count;

            // at each level traverse through all nodes
            while (length > 0) {
                TreeNode cur = q.Dequeue();
                length--;

                curVals.Add(cur.val);

                if(cur.left != null) {
                    q.Enqueue(cur.left);
                }

                if(cur.right != null) {
                    q.Enqueue(cur.right);
                }
            }

            // after the level is processed then add curVals to result
            result.Add(curVals);
        }

        return result;
    }
}
