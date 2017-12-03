using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortal
{
    class Assignment1
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(palauta());
        //    Console.ReadLine();
        //}
       
        static List<int> palauta()
        {

            List<int> testi1 = new List<int>();

            for(int i = 0;i <= 100; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                
                }
                else if(i % 5 == 0)
                {
                    testi1.Add(i);
                }
                else if (i % 3 == 0)
                {
                    testi1.Add(i);
                }
            }

            return testi1;
        }

    }
}
