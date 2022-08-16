using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            relogio();
        }


        static void relogio()
        {
            int seg = 0;
            int min = 0;
            int hour = 0;

            while (seg < 10)
            {

                seg++;
                Thread.Sleep(1000);

                while (seg == 10)
                {
                    min++;
                    seg = 0;

                    while (min == 10)
                    {
                        hour++;
                        min = 0;
                    }
                }
                Console.Clear();
                Console.WriteLine(hour + ":" + min + ":" + seg);

            }


        }
    }
}