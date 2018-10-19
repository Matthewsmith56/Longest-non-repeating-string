using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_non_repeating_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            char[] input = Console.ReadLine().ToCharArray();

            List<char> nonRep = new List<char>();
            List<char> copiedList = new List<char>();

            int index = 0;

            foreach (var i in input)
            {
                if (nonRep.Count == 0)
                {
                    nonRep.Add(i);
                }
                else if (i != nonRep[index])
                {
                    nonRep.Add(i);
                    index++;
                }
                else if (i == nonRep[index] && nonRep.Count > copiedList.Count)
                {
                    copiedList = nonRep.ToList();
                    nonRep.Clear();
                    index = 0;
                }
            }
            if (copiedList.Count > nonRep.Count)
            {
                foreach (var i in copiedList)
                {
                Console.Write(i);
                }
                    Console.WriteLine();
            }
            else if (copiedList.Count < nonRep.Count)
            {
                foreach (var i in nonRep)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
