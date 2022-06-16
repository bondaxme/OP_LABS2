using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace lab3
{
    public class BooleanVector
    {
        private string vector;

        public BooleanVector(string vector)
        {
            this.vector = vector;
        }
            
        public BooleanVector()
        {
            vector = "1010010";
        }

        public int GetLength()
        {
            return vector.Length;
        }

        public string Vector
        {
            get => vector;
            set => vector = value;
        }


        public int Weight()
        {
            int weight = 0;
            foreach (var ch in vector)
            {
                if (ch == '1') weight++;
            }

            return weight;
        }


        public static BooleanVector operator &(BooleanVector B1, BooleanVector B2)
        {
            string conjunction = "";
            for (int i = 0; i < B1.GetLength(); i++)
            {
                if (B1.vector[i] == B2.vector[i] && B1.vector[i] == '1') conjunction += 1;
                else conjunction += 0;
            }

            BooleanVector B3 = new BooleanVector(conjunction);
            return B3;
        }


        public static BooleanVector operator ~(BooleanVector B1)
        {
            string inversion = "";
            for (int i = 0; i < B1.GetLength(); i++)
            {
                if (B1.vector[i] == '0')
                {
                    inversion += 1;
                }
                else
                {
                    inversion += 0;
                }
            }

            BooleanVector B2 = new BooleanVector(inversion);
            return B2;
        }
        
        public void Output(string vector_name)
        {
            Console.WriteLine($"{vector_name}:\t{vector}");
        }
        
        
    }
}