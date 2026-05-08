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
        int res = 0;
        if(root == null) return res;
        Helper(root, root.val, ref res);
        return res;
    }

    public void Helper(TreeNode root, int max, ref int res) {
        if(root == null) return;

        if(max <= root.val) {
            res++;
        }

        max = Math.Max(root.val, max);

        Helper(root.left, max, ref res);
        Helper(root.right, max, ref res);
    }
}
