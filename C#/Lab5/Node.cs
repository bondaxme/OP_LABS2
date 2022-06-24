namespace lab5
{
    public class Node
    {
        public int Num { get; set; }
        public Node Right;
        public Node Left;

        public Node(int value)
        {
            Num = value;
            Right = null;
            Left = null;
        }
    }
}