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
    // start from 0 in preOrder
    public int preIndex = 0;

    // store all indexes of inOrder
    public Dictionary<int, int> inOrderIndexes = new Dictionary<int, int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // edge cases
        if(preorder == null || inorder == null) {
            return null;
        }

        // fill the inOrderIndexes map
        for(int i = 0; i < inorder.Length; i++) {
            inOrderIndexes[inorder[i]] = i;
        }

        // to dfs pass the boundaries for where to start in inOrder array
        return dfs(preorder, 0, inorder.Length - 1);
    }

    public TreeNode dfs(int[] preorder, int inLeft, int inRight) {
        // base case
        if(inLeft > inRight) {
            return null;
        }

        // at very first the 0 index is root in preOrder
        int preOrderRootVal = preorder[preIndex];
        TreeNode root = new TreeNode(preOrderRootVal);

        //move to next preOrder node
        preIndex++;

        // get the inOrder Root node
        int inOrderRootIndex = inOrderIndexes[preOrderRootVal];

        root.left = dfs(preorder, inLeft, inOrderRootIndex - 1);

        root.right = dfs(preorder, inOrderRootIndex + 1, inRight);

        return root;
    } 
}
