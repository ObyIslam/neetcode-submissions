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

    public bool IsSubtree(TreeNode root, TreeNode subRoot) {

        if(root == null)
        {
            return false;
        }

        // Check if the current tree matches subRoot
        if(IsSameTree(root, subRoot))
        {
            return true;
        }

        // Search left and right subtrees
        return IsSubtree(root.left, subRoot) ||
               IsSubtree(root.right, subRoot);
    }


    private bool IsSameTree(TreeNode p, TreeNode q)
    {
        // Both trees ended at the same time
        if(p == null && q == null)
        {
            return true;
        }

        // One tree ended before the other
        if(p == null || q == null)
        {
            return false;
        }

        // Values are different
        if(p.val != q.val)
        {
            return false;
        }

        // Check both children
        return IsSameTree(p.left, q.left) &&
               IsSameTree(p.right, q.right);
    }
}
