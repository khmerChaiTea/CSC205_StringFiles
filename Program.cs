using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_StringFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "abcdefg";

            for (int i = 0; i < str.Length; i += 2) 
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine();

            foreach (char c in str)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
