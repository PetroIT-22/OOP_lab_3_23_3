using System;
using System.IO;

namespace OOP_lab_3_23_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string str = file.ReadToEnd();

            string[] words = str.Split(new char[] { (char)(92), '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            StreamWriter newFile = File.CreateText("output.txt");

            foreach (string word in words)
            {
                if (word.Length < 5)
                {
                    newFile.Write("{0} ", word);
                }
            }

            newFile.Close();
        }
    }
}
