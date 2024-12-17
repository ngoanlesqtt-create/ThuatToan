﻿


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
    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> result = new List<double>();

        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            double levelSum = 0;

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode currentNode = queue.Dequeue();
                levelSum += currentNode.val;

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);

            }
            result.Add(levelSum / levelSize);
        }

        return result;
    }
}
