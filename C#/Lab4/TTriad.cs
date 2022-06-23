namespace lab4
{
    public abstract class TTriad
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        
        protected TTriad(int n1, int n2, int n3)
        {
            Number1 = n1;
            Number2 = n2;
            Number3 = n3;
        }
        
        public abstract void IncreaseNumber1(int n);
        public abstract void DecreaseNumber1(int n);
        public abstract void IncreaseNumber2(int n);
        public abstract void DecreaseNumber2(int n);
        public abstract void IncreaseNumber3(int n);
        public abstract void DecreaseNumber3(int n);
    }
}