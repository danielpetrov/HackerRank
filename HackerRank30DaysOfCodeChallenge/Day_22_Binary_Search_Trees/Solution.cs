namespace Day_22_Binary_Search_Trees
{
    using System;

    internal class Solution
    {
        private static int maxHeight;

        private static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        private static int getHeight(Node root)
        {
            maxHeight = 0;

            dfs(root, 1);

            return maxHeight;
        }

        private static void dfs(Node root, int height)
        {
            if (root.left == null && root.right == null)
            {
                maxHeight = Math.Max(height, maxHeight);
                return;
            }

            if(root.left != null)
            {
                dfs(root.left, height + 1);
            }
            
            if(root.right != null)
            {
                dfs(root.right, height + 1);
            }
            
        }

        private class Node
        {
            public Node left, right;
            public int data;

            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        private static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else {
                Node cur;
                
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}