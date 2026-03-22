using MyLinkedList;
using MyBinaryTree;

namespace MainProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            MyQueue<string> queue = new MyQueue<string>();

            stack.Push("apple");
            stack.Push("banana");
            stack.Push("cherry");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());



            MyBinaryTree<int> tree = new MyBinaryTree<int>();

            // Add
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);

            Console.WriteLine("=== In-Order Traversal (Sorted) ===");
            foreach (var item in tree.InOrder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n=== Pre-Order Traversal ===");
            foreach (var item in tree.PreOrder())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n=== Post-Order Traversal ===");
            foreach (var item in tree.PostOrder())
            {
                Console.Write(item + " ");
            }

            // Remove
            Console.WriteLine("\n\n=== Removing 20 (leaf node) ===");
            tree.Remove(20);

            Console.WriteLine("=== Removing 30 (node with one child) ===");
            tree.Remove(30);

            Console.WriteLine("=== Removing 50 (node with two children) ===");
            tree.Remove(50);

            Console.WriteLine("\n=== In-Order After Removals ===");
            foreach (var item in tree)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}