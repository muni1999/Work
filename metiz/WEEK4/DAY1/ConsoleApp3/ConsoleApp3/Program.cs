namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // Push 1 onto the stack
            stack.Push(2); // Push 2 onto the stack
            stack.Push(3); // Push 3 onto the stack

            Console.WriteLine("Stack (LIFO) behavior:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // Pop elements (3, 2, 1)
            }

        
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); // Enqueue 1 into the queue
            queue.Enqueue(2); // Enqueue 2 into the queue
            queue.Enqueue(3); // Enqueue 3 into the queue

            Console.WriteLine("\nQueue (FIFO) behavior:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); // Dequeue elements (1, 2, 3)
            }
        }
    }
}
