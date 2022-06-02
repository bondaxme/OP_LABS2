using System;
using System.IO;
using System.Linq;

namespace lab1._1
{
    public static class Library
    {
        public static string Input()
        {
            string text = "";
            Console.WriteLine("Enter your text:\n Write @ at the beginning of a line to stop input.\n");
            while (true) {
                string line = Console.ReadLine();
                if (line.IndexOf('@') == 0) 
                    break;
                text += line + "\n";
            }

            if (text[text.Length - 1] == '\n') text = text.Substring(0, text.Length - 1);

            return text;
        }
        
        public static void FileWrite(string text, string filename)
        {
            Console.Write("\nIf you want to append your input, enter a. Otherwise enter w: ");
            char mode = Convert.ToChar(Console.ReadLine());
            while (mode != 'a' && mode != 'w')
            {
                Console.Write("Wrong mode, enter again: ");
                mode = Convert.ToChar(Console.ReadLine());
            }
            if (mode == 'a') 
            {
                StreamWriter file = new StreamWriter(filename, true);
                file.Write($"\n{text}");
                file.Close();
            }
            if (mode == 'w')
            {
                StreamWriter file = new StreamWriter(filename, false);
                file.Write(text);
                file.Close();
            }
            
        }

        public static void ReadFile(string filename)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                Console.WriteLine($"\nOpen {filename}\n{file.ReadToEnd()}");
            }
        }
        
        public static string DeleteWords(string text, ref int words_counter)
        {
            string[] lines_list = text.Split('\n');
            string new_text = "";

            foreach (var line in lines_list)
            {
                string[] words_list = line.Split();
                string new_line = "";
                foreach (var word in words_list)
                {
                    if (word.Length == 1 && word.All(ch => Char.IsLetter(ch)))
                    {
                        words_counter++;
                        continue;
                    }
                    new_line += word + " ";
                }
                new_text += new_line + "\n";
            }

            return new_text;
        }

        public static string DeleteDuplicates(string text, ref int counter_comma, ref int counter_dot, ref int counter_space)
        {
            string new_text = "";
            for (int i = 0; i < text.Length - 1; i++) {
                if (text[i] == text[i+1]){
                    if (text[i] == ',')
                        counter_comma++;
                    else if (text[i] == '.')
                        counter_dot++;
                    else if (text[i] == ' ')
                        counter_space++;
                    else
                        new_text += text[i];
                }
                else new_text += text[i];
            }

            new_text += text[text.Length - 1];

            return new_text;
        }
        
        public static void ChangeFile(string old_file, string new_file)
        {
            string text;
            int commas = 0;
            int dots = 0;
            int spaces = 0;
            int words = 0;
            
            using (StreamReader oldFile = new StreamReader(old_file))
            {
                text = DeleteDuplicates(oldFile.ReadToEnd(), ref commas, ref dots, ref spaces);
                text = DeleteWords(text, ref words);
                text += $"Removed commas - {commas}, dots - {dots}, spaces - {spaces}, words - {words}";
            }

            using (StreamWriter newFile = new StreamWriter(new_file))
            {
                newFile.Write(text);
            }
        }
    }
}