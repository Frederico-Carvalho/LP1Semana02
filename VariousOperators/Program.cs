using System;
using System.Security.Cryptography.X509Certificates;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo: ");
            byte n = byte.Parse(Console.ReadLine());
           
            byte x =(byte)(n / 2);
            Console.WriteLine(x);

            byte y =(byte)(n << 3);
            Console.WriteLine(y);

            byte z =(byte)(n ^ 6);
            Console.WriteLine(z);

            bool r = n > 10;
            Console.WriteLine(r);

        }
    }
}
