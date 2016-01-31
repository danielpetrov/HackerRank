namespace Day_23_Review_Binary_Trees
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class Solution {
        static void levelOrder(Node root)
        {
            StringBuilder sb = new StringBuilder();
            bfs(root, sb);

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        static void bfs(Node root, StringBuilder sb)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node n = queue.Dequeue();
                sb.Append(n.data);
                sb.Append(" ");
                if (n.left != null)
                {
                    queue.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    queue.Enqueue(n.right);
                }
            }
        }

        static Node insert(Node root, int data)
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
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}

