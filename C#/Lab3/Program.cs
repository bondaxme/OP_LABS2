using System;

namespace lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            BooleanVector B1 = Funcs.EnterVector();
            BooleanVector B2 = new BooleanVector();
            
            Funcs.ConvertSize(B1, B2);
            
            B1.Output("B1 vector");
            B2.Output("B2 vector");

            B1 = ~B1;
            B1.Output("~B1 vector");

            BooleanVector B3 = B1 & B2;
            B3.Output("B3 vector");
            Console.WriteLine($"B3 weight is {B3.Weight()}");



        }
    }
}