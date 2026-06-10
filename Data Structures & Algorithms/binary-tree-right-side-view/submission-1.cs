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
    public List<int> RightSideView(TreeNode root) {
        // edge cases
        var result = new List<int>();
        if(root == null) return result;

        // BFS
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        // for each level
        while(q.Count > 0) {
            var length = q.Count;
            // create a temp node to store rightMostNode
            TreeNode rightMostNode = null;

            // at each level, iterate through all nodes
            while (length > 0) {
                TreeNode cur = q.Dequeue();
                length--;

                // after going to deep, at length = 0, 
                // this will be right most node
                rightMostNode = cur;

                if(cur.left != null) {
                    q.Enqueue(cur.left);
                }

                if(cur.right != null) {
                    q.Enqueue(cur.right);
                }
            }

            // after processing each level, 
            //store the rightMostNode to result
            result.Add(rightMostNode.val);
        } 

        return result;  
    }
}
