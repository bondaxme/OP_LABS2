using System;
using System.Collections.Generic;

namespace lab1._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input_file = "input.bin";
            string output_file = "output.bin";
            
            Library.createFile(input_file);
            Library.Input(input_file);
            
            Console.WriteLine("\nThe list of applicants: ");
            List<Applicants> applicant_list = Library.readFile(input_file);
            
            Library.removeOldApplicants(applicant_list);

            Library.writeNewFile(output_file, applicant_list);
            Console.WriteLine("\nThe list of applicants ready to army: ");
            Library.readFile(output_file);
        }
    }
}