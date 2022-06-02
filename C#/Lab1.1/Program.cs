namespace lab1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string first_file = "input.txt";
            string second_file = "output.txt";

            string text = Library.Input();
            
            Library.FileWrite(text, first_file);
            Library.ReadFile(first_file);
            
            Library.ChangeFile(first_file, second_file);
            Library.ReadFile(second_file);
        }
    }
}