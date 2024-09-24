using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExampleOfC_
{
  
    public static class ApplicationExtenstionMethods
    {
        public static string Decoreate(this string name)
        {
            string newName = name.Replace(" ", "*") + "   " + DateTime.Now;
            return newName;
        }

        public static string GetFirstString(this string str)
        {
            return str.Substring(0, 1);
        }

        public static bool IsEven(this int num)
        {
            bool result = num % 2 == 0;
            return result;
        }
    }
}
/*
 * I Am Raja;
 * I
 *  
 *  A
 *  m
 *   
 *   R
 *   A
 *   j
 *   a
 *   
 */
