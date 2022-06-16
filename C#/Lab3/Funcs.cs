using System;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Policy;

namespace lab3
{
    public class Funcs
    {
        public static BooleanVector EnterVector()
        {
            string vector = "";
            Console.Write("Enter the size of boolean vector: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                vector += rand.Next(0, 2);
            }

            BooleanVector B = new BooleanVector(vector);
            
            return B;
        }


        public static void ConvertSize(BooleanVector B_reload, BooleanVector B_default)
        {
            if (B_reload.GetLength() <= B_default.GetLength())
            {
                B_default.Vector = B_default.Vector.Substring(B_default.GetLength() - B_reload.GetLength());
            }
            else
            {
                B_default.Vector =  String.Concat(Enumerable.Repeat("0",B_reload.GetLength() - B_default.GetLength())) + B_default.Vector;
            }
        }
    }
}