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
    public int count = 0;
    public int result = 0;

    public int KthSmallest(TreeNode root, int k) {
        dfs(root, k);
        return result;
    }

    public void dfs(TreeNode node, int k) {
        // base case
        if(node == null) {
            return;
        }

        // first go left and search for value
        dfs(node.left, k);

        // increament the counter
        count++;

        // we found that index
        if(count == k) {
            result = node.val;
            return;
        }

        // if still not found go search right
        dfs(node.right, k);
    }
}
