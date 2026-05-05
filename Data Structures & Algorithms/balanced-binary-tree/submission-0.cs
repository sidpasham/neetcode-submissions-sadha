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
    public bool IsBalanced(TreeNode root) {
        bool isBal = true;
        Dfs(root, ref isBal);
        return isBal;
    }

    public int Dfs(TreeNode root, ref bool isBal) {
        if (root == null) return 0;

        int left = Dfs(root.left, ref isBal);
        int right = Dfs(root.right, ref isBal);

        if(Math.Abs(left - right) > 1) {
            isBal = false;
        }

        return 1 + Math.Max(left, right);
    }
}
