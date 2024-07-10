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
            string s = "Visual C#";
            System.Console.WriteLine(s.Substring(7, 2));
            // Output: "C#"

            System.Console.WriteLine(s.Replace("C#", "Basic"));
            // Output: "Visual Basic Express"

            System.Console.WriteLine(s.ToUpper());
            // Output: "VISUAL C#"

            System.Console.WriteLine(s.Contains("C#"));
            //Output: True

            System.Console.WriteLine(s.Insert(0, "I like "));
            //Output: I like Visual C#
        }
    }
}
