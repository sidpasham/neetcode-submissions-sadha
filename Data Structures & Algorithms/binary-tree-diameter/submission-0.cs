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

    public int DiameterOfBinaryTree(TreeNode root) {
        int h  = 0;
        Dfs(root, ref h);
        return h;
    }

    public int Dfs(TreeNode root, ref int h) {
        // breaking condition
        if (root == null) return 0;

        int left = Dfs(root.left, ref h);
        int right = Dfs(root.right, ref h);

        h = Math.Max(h, left + right);

        return 1 + Math.Max(left, right);

    }
}
