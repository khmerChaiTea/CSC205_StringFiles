﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_StringFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            string myStr = "25";
            num = int.Parse(myStr);
            Console.WriteLine("int.Parse method result: " + num);
            num = Convert.ToInt32(myStr);
            Console.WriteLine("Convert.ToInt32 method result: " + num);
        }
    }
}
