



using System.Reflection.Metadata.Ecma335;

public class Solution
{
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
    private TreeNode ConvertToBST(int[] nums, int left, int right)
    {
        //[-10,-3,0,5,9]
        if (left > right) return null;

        int mid = left + (right - left) / 2;

        TreeNode node = new TreeNode(nums[mid]);

        node.left = ConvertToBST(nums, left, mid - 1);
        node.right = ConvertToBST(nums, mid + 1, right);

        return node;
    }

    public TreeNode SortedArrayToBST(int[] nums)
    {
        return ConvertToBST(nums, 0, nums.Length - 1);
    }
}
