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

        while(q.Count > 0) {
            List<int> currVals = new List<int>();
            var length = q.Count;

            while(length > 0) {
                TreeNode curr = q.Dequeue();
                length--;

                currVals.Add(curr.val);

                if(curr.left != null) {
                    q.Enqueue(curr.left);
                }

                if(curr.right != null) {
                    q.Enqueue(curr.right);
                }
            }

            result.Add(currVals);
        }

        return result;
    }
}
