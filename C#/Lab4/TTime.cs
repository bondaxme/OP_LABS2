using System;

namespace lab4
{
    public class TTime : TTriad
    {
        public TTime(int n1, int n2, int n3) : base(n1, n2, n3)
        {
        }

        public override void IncreaseNumber1(int n)
        {
            Number1 += n;
            while (Number1 >= 24)
            {
                Number1 -= 24;
            }
        }

        public override void DecreaseNumber1(int n)
        {
            Number1 -= n;
            while (Number1 < 0)
            {
                Number1 += 24;
            }
        }

        public override void IncreaseNumber2(int n)
        {
            Number2 += n;
            while (Number2 >= 60)
            {
                Number2 -= 60;
                IncreaseNumber1(1);
            }
        }

        public override void DecreaseNumber2(int n)
        {
            Number2 -= n;
            while (Number2 < 0)
            {
                Number2 += 60;   
                DecreaseNumber1(1);
            }
        }

        public override void IncreaseNumber3(int n)
        {
            Number3 += n;
            while (Number3 >= 60)
            {
                Number3 -= 60;
                IncreaseNumber2(1);
            }
        }

        public override void DecreaseNumber3(int n)
        {
            Number3 -= n;
            while (Number3 < 0)
            {
                Number3 += 60;   
                DecreaseNumber2(1);
            }
        }

        public void Output()
        {
            Console.WriteLine($"{Funcs.ChangeFormat(Number1)}:{Funcs.ChangeFormat(Number2)}:{Funcs.ChangeFormat(Number3)}");
        }
    }
}