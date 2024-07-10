using System;
using System.IO;

namespace ThinkSharp
{
    public class ListFile
    {
        public static void Main()
        { //make sure words.txt is in the same folder as the .exe file
            ProcessFile("words.txt");
        }
        private static void ProcessFile(string filename)
        {
            string line;
            int count = 1;
            TextReader reader = new StreamReader(filename);
            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(count + ": " + line);
                count++;
            }
            reader.Close();
        }
    }
}