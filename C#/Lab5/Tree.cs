using System;

namespace lab5
{
    public class Tree
    {
        private Node Root;

        public Tree()
        {
            Root = null;
        }

        public void AddNode(int num)
        {
            AddNodeRecursion(num, ref Root);
        }

        private void AddNodeRecursion(int num, ref Node parent)
        {
            if (parent == null) parent = new Node(num);
            else
            {
                if (parent.Num < num)
                {
                    AddNodeRecursion(num, ref parent.Right);
                }
                else if (parent.Num > num)
                {
                    AddNodeRecursion(num, ref parent.Left);
                }
            }
        }

        public void FindElements(ref int positive, ref int negative)
        {
            FindElementsRecursion(ref Root, ref positive, ref negative);
        }

        private void FindElementsRecursion(ref Node parent, ref int positive, ref int negative)
        {
            if (parent == null) return;
            FindElementsRecursion(ref parent.Left, ref positive, ref negative);
            FindElementsRecursion(ref parent.Right, ref positive, ref negative);
            
            if (parent.Num > 0) positive++;
            if (parent.Num < 0) negative++;
        }

        public void PrintTree()
        {
            PrintTreeRecursion(ref Root, 0);
        }
        
        private void PrintTreeRecursion(ref Node parent, int height)
        {
            if (parent == null) return;
            
            PrintTreeRecursion(ref parent.Right, ++height);

            for (int i = 1; i < height; i++)
            {
                Console.Write("\t");
            }

            Console.WriteLine(parent.Num);
            PrintTreeRecursion(ref parent.Left, height);
        }
    }
}