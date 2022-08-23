using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public static class StringArrExtension
    {
        public static void PrintArray(this string[] array)
        {
            Console.WriteLine(string.Join("\n", array));
        }
    }
}
