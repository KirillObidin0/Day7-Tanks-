using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;

namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] T34 = new Tank[5];
            Tank[] Pantera = new Tank[5];

            for (int i = 0; i < T34.Length; i++)
            {
                T34[i] = new Tank("T34"+i);
            }
            for (int i = 0; i < Pantera.Length; i++)
            {
                Pantera[i] = new Tank("Pantera" + i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(T34[i].GetInfo());
                Console.WriteLine("--------------");
                Console.WriteLine(Pantera[i].GetInfo());
                Console.WriteLine("--------------");
                try
                {
                    Console.WriteLine("Winner: "+(T34[i] * Pantera[i]).GetName());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("--------------");
            }
        }
    }
}
