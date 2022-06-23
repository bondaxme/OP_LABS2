using System;

namespace lab4
{
    public class TDate : TTriad
    {
        public TDate(int n1, int n2, int n3) : base(n1, n2, n3)
        {
        }

        public override void IncreaseNumber1(int n)
        {
            Number1 += n;
            while (Number1 > 30)
            {
                Number1 -= 30;
                IncreaseNumber2(1);
            }
        }
        
        public override void DecreaseNumber1(int n)
        {
            Number1 -= n;
            while (Number1 <= 0)
            {
                Number1 += 30;
                DecreaseNumber2(1);
            }
        }
        
        public override void IncreaseNumber2(int n)
        {
            Number2 += n;
            while (Number2 > 12)
            {
                Number2 -= 12;
                IncreaseNumber3(1);
            }
        }
        
        public override void DecreaseNumber2(int n)
        {
            Number2 -= n;
            while (Number2 <= 0)
            {
                Number2 += 12;
                DecreaseNumber3(1);
            }
        }
        
        public override void IncreaseNumber3(int n)
        {
            Number3 += n;
        }

        public override void DecreaseNumber3(int n)
        {
            Number3 -= n;
        }

        public void Output()
        {
            Console.WriteLine($"{Funcs.ChangeFormat(Number1)}.{Funcs.ChangeFormat(Number2)}.{Funcs.ChangeFormat(Number3)}");
        }
    }
}