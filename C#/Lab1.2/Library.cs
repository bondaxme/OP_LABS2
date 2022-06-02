using System;
using System.Collections.Generic;
using System.IO;

namespace lab1._2
{
    public class Library
    {
        public static void Input(string filename)
        {
            Console.Write("Enter the amount of applicants you want to input: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the full name: ");
                string full_name = Console.ReadLine();
                Console.Write("Enter the birth date [DD.MM.YYYY]: ");
                string birth = Console.ReadLine();
                Console.Write("Enter the sex [Male/Female]: ");
                string sex = Console.ReadLine();
                while (sex != "Male" && sex != "Female")
                {
                    Console.Write("Wrong data, enter using this format [Male/Female]: ");
                    sex = Console.ReadLine();
                }
                enterToFile(filename, full_name, birth, sex);
            }
        }

        
        public static void createFile(string filename)
        {
            Console.Write("If you want to append your input enter a. Otherwise enter w: ");
            char mode = Convert.ToChar(Console.ReadLine());
            while (mode != 'a' && mode != 'w')
            {
                Console.Write("Enter correct letter: ");
                mode = Convert.ToChar(Console.ReadLine());
            }

            if (mode == 'a')
            {
                BinaryWriter file = new BinaryWriter(File.Open(filename, FileMode.Append));
                file.Close();
            }

            if (mode == 'w')
            {
                BinaryWriter file = new BinaryWriter(File.Open(filename, FileMode.Create));
                file.Close();
            }
        }


        public static void enterToFile(string filename, string full_name, string birth, string sex)
        {
            using (BinaryWriter file = new BinaryWriter(File.Open(filename, FileMode.Append)))
            {
                file.Write(full_name);
                file.Write(birth);
                file.Write(sex);
            }
        }

        
        public static List<Applicants> readFile(string filename)
        {
            List<Applicants> applicant_list = new List<Applicants>();
            using (BinaryReader file = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                while (true)
                {
                    try
                    {
                        string full_name = file.ReadString();
                        string birth = file.ReadString();
                        string sex = file.ReadString();
                        Applicants applicant = new Applicants(full_name, birth, sex);
                        applicant_list.Add(applicant);
                        applicant.Output();
                    }
                    catch (Exception e)
                    {
                        break;
                    }
                }
            }

            return applicant_list;
        }


        public static void removeOldApplicants(List<Applicants> list)
        {
            List<Applicants> temp = list.GetRange(0, list.Count);
            Console.WriteLine("\nRemoved applicants (>35 yo): ");
            foreach (var applicant in temp)
            {
                if (calculateAge(applicant.birth) > 35)
                {
                    list.Remove(applicant);
                    applicant.Output();
                }
            }
        }


        public static void writeNewFile(string filename, List<Applicants> list)
        {
            using (BinaryWriter file = new BinaryWriter(File.Open(filename, FileMode.Create)));
            {
                foreach (var applicant in list)
                {
                    int age = calculateAge(applicant.birth);
                    if (age >= 18 && age < 27 && applicant.sex == "Male")
                    {
                        enterToFile(filename, applicant.full_name, applicant.birth, applicant.sex);
                    }
                }
            }
        }

        
        public static int calculateAge(string birth)
        {
            DateTime today = DateTime.Now;
            DateTime birth_date = Convert.ToDateTime(birth);
            int age = (int) ((today - birth_date).Days / 365.25);
            return age;
        }
    }
}