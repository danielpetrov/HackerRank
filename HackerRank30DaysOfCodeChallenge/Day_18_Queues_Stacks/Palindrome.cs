namespace Day_18_Queues_Stacks
{
    using System.Collections.Generic;

    internal class Palindrome
    {
        private Stack<char> stack;
        private Queue<char> queue;

        public Palindrome()
        {
            this.stack = new Stack<char>();
            this.queue = new Queue<char>();
        }

        internal void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        internal char dequeueCharacter()
        {
            return this.queue.Dequeue();
        }

        internal void pushCharacter(char c)
        {
            this.stack.Push(c);
        }

        internal char popCharacter()
        {
            return this.stack.Pop();
        }
    }
}