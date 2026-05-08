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
        List<int> mem = new List<int>();
        InOrder(root, ref mem);

        foreach(var m in mem) {
            Console.WriteLine(m);
        }

        if(k >= 0) {
            return mem[k - 1];
        }
        return -1;
    }

    public void InOrder(TreeNode root, ref List<int> mem) {
        if (root == null) return;
        InOrder(root.left, ref mem);
        mem.Add(root.val);
        InOrder(root.right, ref mem);
    }
}
