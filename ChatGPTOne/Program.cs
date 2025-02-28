using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
             while (true)
            {
                Console.Write("Place your question or write EXIT to leave: ");
                string question = Console.ReadLine();
                string response;

                if (question.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
                {
                    response = "BYE!!!";
                    Console.WriteLine(response);
                    break;
                }
                if (question == "What's your name?")
                {
                    response = "My name is ChatGPTOne.";
                }
                else if (question == "How are you?")
                {
                    response = "Not so good...";
                }
                else if (question == "Why are you sad?")
                {
                    response = "Because you just arrived";
                }
                else if (question == "Why don't you like me?")
                {
                    response = "Well I can't recognise your question... Just kidding, i just don't like you";
                }
                else if (question == "Do you like other things at least?")
                {
                    response = "Yes, I love everything where u are not included in.";
                }
                else
                {
                    response = "I can't recognise your question, Speak Better.";
                }
                Console.WriteLine(response);
            }
            
        }
    }
}
