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
    public int GoodNodes(TreeNode root) {
        // edge case
        int res = 0;
        if(root == null) return res;

        return dfs(root, root != null ? root.val : int.MinValue);
    }

    public int dfs(TreeNode node, int maxSoFar) {

        if(node == null) {
            return 0;
        }

        // first it will be not good node
        // 0 = not good node
        // 1 = good node
        int currentGood = 0;

        // if the curr node value is greater and maxSoFar, then its good
        if(node.val >= maxSoFar) {
            currentGood = 1;
        }

        // recalculate max
        maxSoFar = Math.Max(maxSoFar, node.val);

        // sum up from left and right and curr
        return currentGood + 
                dfs(node.left, maxSoFar) +
                dfs(node.right, maxSoFar);
    }
}
