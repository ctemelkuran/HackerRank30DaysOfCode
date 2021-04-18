﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Day9_Recursion
{
    class Program
    {

        // Complete the factorial function below.
        static int factorial(int n)
        {
            
            if (n >= 1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return 1;
            }

        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            Console.WriteLine(result);

        }
    }

}
