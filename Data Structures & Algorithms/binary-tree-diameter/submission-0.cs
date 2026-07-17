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

    int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root) {

        Depth(root);

        return diameter;
    }

    private int Depth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }

        int left = Depth(root.left);
        int right = Depth(root.right);

        // Check if this node creates the longest path
        diameter = Math.Max(diameter, left + right);

        // Return height of this node
        return 1 + Math.Max(left, right);
    }
}