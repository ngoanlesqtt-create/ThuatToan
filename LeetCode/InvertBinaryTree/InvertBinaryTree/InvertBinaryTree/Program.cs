
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        TreeNode leftNode = InvertTree(root.left);
        TreeNode rightNode = InvertTree(root.right);

        root.left = rightNode;
        root.right = leftNode;
        return root;
    }
}
