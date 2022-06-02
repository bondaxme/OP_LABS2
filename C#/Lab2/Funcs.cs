using System;
using System.Collections.Generic;

namespace lab2
{
    public class Funcs
    {
        public static Vector createVector()
        {
            Console.Write("Enter X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Z coordinate: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Vector vector = new Vector(x, y, z);
            return vector;
        }
        
        public static Vector[] createArray()
        {
            List<Vector> vector_list = new List<Vector>();
            Console.Write("Enter the amount of vectors you want to input: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1} vector:");
                vector_list.Add(createVector());
            }

            return vector_list.ToArray();
        }

        public static Vector maxVector(Vector[] array)
        {
            Vector max_vector = array[0];
            foreach (var vector in array)
            {
                if (vector.GetLength() > max_vector.GetLength())
                {
                    max_vector = vector;
                }
            }

            return max_vector;
        }
        
        public static void output(Vector[] array, Vector max_vector)
        {
            Console.WriteLine("\nVectors:");
            foreach (var vector in array)
            {
                vector.OutputVector();
            }
            
            Console.WriteLine("\nThe longest vector is:");
            max_vector.OutputVector();
        }
    }
}