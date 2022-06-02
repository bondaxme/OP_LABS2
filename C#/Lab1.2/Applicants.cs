using System;

namespace lab1._2
{
    public class Applicants
    {
        public string full_name;
        public string birth;
        public string sex;

        public Applicants(string full_name, string birth, string sex)
        {
            this.full_name = full_name;
            this.birth = birth;
            this.sex = sex;
        }

        public void Output()
        {
            Console.WriteLine($"Full name: {full_name}, birth: {birth}, sex: {sex}");
        }
    }
}