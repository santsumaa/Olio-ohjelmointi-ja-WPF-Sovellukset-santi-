﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_11
{
    class OpiskelijaPoikkeus : Exception
    {
        public OpiskelijaPoikkeus(string message) : base(message)
        {
            Console.WriteLine();
            Console.WriteLine("-----ERROR-----");
            Console.WriteLine("Error: " + message);
            Console.WriteLine("-----ERROR-----");
            Console.WriteLine();
        }
    }
}
