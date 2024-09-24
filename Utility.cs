using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfC_
{
    public class Utility
    {
        public static string Decoreate(string name)
        {
            string newName = name.Replace(" ", "*");
            newName = newName + "   " + DateTime.Now;
            return newName;
        }
    }
}
