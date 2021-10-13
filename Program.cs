using oop_lesson5_eighball;
using System;
using System.Collections.Generic;

namespace oop_lesson5_eighball
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Magic 8-Ball *****");
            Console.WriteLine();

            Console.Write("Ask me a question: ");
            Console.ReadLine();

            List<string> magic8Ball = new List<string>();

            //Affirmative answers
            magic8Ball.Add("It is certain.");
            magic8Ball.Add("It is decidely so.");
            magic8Ball.Add("Without a doubt.");
            magic8Ball.Add("Yes definitely.");
            magic8Ball.Add("You may rely on it.");
            magic8Ball.Add("As I see it, yes.");
            magic8Ball.Add("Most likely.");
            magic8Ball.Add("Outlook good.");
            magic8Ball.Add("Yes.");
            magic8Ball.Add("Signs point to yes.");

            //Non-committal answers
            magic8Ball.Add("Reply hazy, try again.");
            magic8Ball.Add("Ask again later.");
            magic8Ball.Add("Better not to tell you now.");
            magic8Ball.Add("Cannot predict now.");
            magic8Ball.Add("Concentrate and ask again.");

            //Negative answers
            magic8Ball.Add("Dont count on it.");
            magic8Ball.Add("My reply is no.");
            magic8Ball.Add("My sources say no.");
            magic8Ball.Add("Outlook not so good.");
            magic8Ball.Add("Very doubtful.");


            Random random = new Random();

            int answers = random.Next(0, 19);
            Console.WriteLine(magic8Ball[answers]);
            
            
            //foreach (string currentQuestion in magic8Ball)
            //{
                //Console.WriteLine(random.Next(0, 19));
            //}
        }
    }
}