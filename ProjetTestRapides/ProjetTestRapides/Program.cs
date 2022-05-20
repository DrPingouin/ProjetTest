using System;
using System.IO;

namespace ProjetTestRapides
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                using (StreamWriter sw = new StreamWriter(@"T:\Préparation de données\OLI - ORANGE - Liberia\Nouvelles Commandes\Test.csv"))
                {
                    long k = 1;
                    for (long i = 0; i < 10000000; i++)
                    {
                        for (long j = 0; j < 5; j++)
                        {
                            sw.WriteLine(k.ToString().PadLeft(8, '0'));
                        }
                        k++;
                    }
                }
                //string line = "";
                /*using (StreamReader sr = new StreamReader(""))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }*/
            }
        }
    }
}
