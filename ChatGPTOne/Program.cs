using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;

            Console.Write("Place your question? or Write EXIT to leave: ");
            question = Console.ReadLine();

            switch (question)
            {
                case "BREAK":
                    response = "Bye!";
                    break;
                
                default:
                    response = "You got me, I'm not THAT smart!";
                    break;
            }

            Console.WriteLine(response);
        }
    }
}
