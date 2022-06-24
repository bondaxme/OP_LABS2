using System;

namespace lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int positive_counter = 0;
            int negative_counter = 0;
            
            Tree tree = new Tree();
            Console.Write("Enter amount of elemets: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element: ");
                int num = Convert.ToInt32(Console.ReadLine());
                tree.AddNode(num);
            }
            tree.PrintTree();
            tree.FindElements(ref positive_counter, ref negative_counter);
            Console.WriteLine($"Positive elements: {positive_counter}, negative elements: {negative_counter}");
        }
    }
}