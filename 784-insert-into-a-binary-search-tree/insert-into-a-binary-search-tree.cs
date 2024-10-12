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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
       
        if (root==null)
            return new TreeNode(val);

       TreeNode current = root;
       
       TreeNode previous = null;
       while(true)
       {
            if (current == null)
            {
                if (previous.val>val)
                    previous.left = new TreeNode(val);
                else
                    previous.right = new TreeNode(val);
                
                break;
            }
            if (current.val > val)
            {
                previous = current;
                current = current.left;
            }
            else
            {
                previous = current;
                current = current.right;
            }
        }
        return root;
    }
}