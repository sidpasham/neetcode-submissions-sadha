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
    public int KthSmallest(TreeNode root, int k) {
        int count = 0;
        int result = 0;
        InOrder(root, k, ref count, ref result);
        return result;
    }

    public void InOrder(TreeNode root, int k, ref int count, ref int result) {
        if (root == null) return;
        InOrder(root.left, k, ref count, ref result);
        count++;
        if(count == k) {
            result = root.val;
        }
        InOrder(root.right, k, ref count, ref result);
    }
}
