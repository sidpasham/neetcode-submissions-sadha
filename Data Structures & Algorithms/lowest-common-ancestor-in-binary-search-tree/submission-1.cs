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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // breaking condition
        if (root == null || p == null || q == null) {
            return null;
        }

        // in a binary search tree, all the left elements are less than root
        // all the right elements are more than root

        // if p and q are less then root, then search left side of the tree
        if (p.val < root.val && q.val < root.val) {
            root = LowestCommonAncestor(root.left, p, q);
        }

        // if p and q are more then root, then search right side of the tree
        if (p.val > root.val && q.val > root.val) {
            root = LowestCommonAncestor(root.right, p, q);
        }
        
        return root;
    }
}
