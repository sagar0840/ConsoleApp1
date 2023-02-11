using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Write a C# program to count occurrences of a character in given string

        static void Main(string[] args)
        {
            string m = "WWW.C,SHARP.COM";



            while (m.Length > 0)

            {

                Console.Write(m[0] + " : ");

                int count = 0;

                for (int j = 0; j < m.Length; j++)

                {

                    if (m[0] == m[j])

                    {

                        count++;

                    }

                }

                Console.WriteLine(count);

                m = m.Replace(m[0].ToString(), string.Empty);

            }

            Console.ReadLine();

        }

    }
}


