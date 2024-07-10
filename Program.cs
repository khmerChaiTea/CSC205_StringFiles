using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_StringFiles
{
    namespace ThinkSharp
    {
        public class BadString
        {
            public static void Main(string[] args)
            {
                ProcessWord("banana");
            }
            public static void ProcessWord(string s)
            {
                char c = GetLastLetter(s);
                Console.WriteLine(c);
            }
            public static char GetLastLetter(string s)
            {
                int index = s.Length; // WRONG!
                char c = s[index];
                return c;
            }
        }
    }
}
