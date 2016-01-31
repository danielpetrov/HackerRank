namespace Day_15_Linked_List
{
    using System;

    internal class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class Solution
    {
        public static Node insert(Node current, int data)
        {
            Node node = new Node(data);
            Node saveHead = null;
            if (current == null)
            {
                current = node;
                current.next = null;
                saveHead = current;
            }
            else
            {
                saveHead = current;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
            }
            return saveHead;
        }
        
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        private static void Main(String[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }

            display(head);
        }
    }
}