namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vector[] vector_array = Funcs.createArray();
            Vector max_vector = Funcs.maxVector(vector_array);
            Funcs.output(vector_array, max_vector);
        }
    }
}