using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            char[] chars = { ' ' };
            string[] stringArray = startString.Split(chars);
            int max = stringArray[0].Length;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max)
                    max = stringArray[i].Length;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
