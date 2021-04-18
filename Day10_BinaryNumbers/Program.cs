#region usings
using System.CodeDom.Compiler;
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
#endregion

namespace Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int current= 0;
            int remainder;
            int max = 0;
    
            List<int> binary = new List<int>();
            
            while (n != 0)
            {
                
                remainder = n % 2;
                if (remainder == 1)
                {
                    current++;
                    if (current > max)
                    {
                        max = current;
                    }
                }
                else
                {
                    current = 0;
                }
                //binary.Add(remainder);
                n = n / 2;
            }
            //binary.Reverse();

            //for (int i = 0; i < (binary.Count-1); i++)
            //{
            //    if (binary[i] == 1 && binary[i] == binary[i+1] )
            //    {
                    
            //        current++;
            //    }
            //}

            Console.WriteLine(max);
            Console.Read();
        }
    }
}
