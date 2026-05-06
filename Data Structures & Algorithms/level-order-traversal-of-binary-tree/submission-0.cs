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
        List<List<int>> result = new List<List<int>>();
        if (root == null) {
            return result;
        }

        Queue<TreeNode> q = new Queue<TreeNode>();        
        q.Enqueue(root);

        while(q.Count > 0) {
            var temp = new List<int>();
            var length = q.Count;

            while(length > 0) {
                var node = q.Dequeue();
                temp.Add(node.val);
                length--;
                
                if(node.left != null) {
                    q.Enqueue(node.left);
                }

                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }           

            result.Add(temp);
        }

        return result;
    }
}
