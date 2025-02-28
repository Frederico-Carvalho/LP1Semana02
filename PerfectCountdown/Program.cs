using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Start number: ");
                int Start = int.Parse(Console.ReadLine());
                Console.Write("Step number: ");
                int Step = int.Parse(Console.ReadLine());

                if (Start <= 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }
                if (Step <= 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }
                if (Step >= Start)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    continue;
                }
                if (Start % Step != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                else
                {
                    for (int x = Start; x >= 0; x -= Step)
                        Console.WriteLine($"{x}");
                    break;
                }

            }
        }
    }
}
