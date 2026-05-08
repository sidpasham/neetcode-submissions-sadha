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
    public bool IsValidBST(TreeNode root) {
        bool isBST = true;
        int left = int.MinValue;
        int right = int.MaxValue;

        Helper(root, left, right, ref isBST);

        return isBST; 
    }

    public void Helper(TreeNode root, int left, int right, ref bool isBST) {
        if(root == null) return;

        // logic condition
        if(!(left < root.val && right > root.val)) {
            isBST = false;
            return;
        }

        Helper(root.left, left, root.val, ref isBST);
        Helper(root.right, root.val, right, ref isBST);
    }
}
