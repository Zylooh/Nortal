using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortal
{
    class Assignment2
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Syötä ensimmäinen string");
        //    string input1 = Console.ReadLine();
        //    Console.WriteLine("Syöta toinen string");
        //    string input2 = Console.ReadLine();

           

        //    if(AnagramChecker(input1, input2))
        //    {
        //        Console.WriteLine("Ovat anagrammeja");
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eivät Ole");
        //        Console.ReadLine();
        //    }

        //}


        public static bool AnagramChecker(string yksi,string kaksi)
        {
            char[] arrayChar1 = yksi.ToUpper().ToCharArray();
            char[] arrayChar2 = kaksi.ToUpper().ToCharArray();

            Array.Sort(arrayChar1);
            Array.Sort(arrayChar2);

            string testi1 = new string(arrayChar1);
            string testi2 = new string(arrayChar2);

            if(testi1 == testi2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
