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
            
            int length = q.Count;
            TreeNode rightMostNode = null;

            // at each level for every node
            while(length > 0) {
                TreeNode curr = q.Dequeue();
                length--;

                rightMostNode = curr;

                if(curr.left != null) {
                    q.Enqueue(curr.left);
                }

                if(curr.right != null) {
                    q.Enqueue(curr.right);
                }
            }

            // after the second while loop, we will get the right most node
            // if no right most node, then we are adding default value 0
            result.Add(rightMostNode.val);
        } 

        return result;  
    }
}
