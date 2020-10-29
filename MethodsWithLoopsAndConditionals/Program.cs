using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static bool ShowAbsValOf1000(bool ones)
        {
            for (int display = 1000; display >= -1000 && display <= 1000; display--)
                
            {
                Console.WriteLine(display);
            }
            return false;
        }

        static bool MultsOfThree(bool threes) 
        {
            for (int display = 3;  display < 1000; display+=3)

            {
                Console.WriteLine(display);
            }
            return false;
        }

        static string AreTheyEqual(int num1, int num2)
        {
            string equality = (num1 == num2) ? "they are equal" : "they are not equal";

            return equality;
        }

        static string EvenOrOdd(int anyGivenNumber)
        {
            string even = (anyGivenNumber % 2 == 0) ? "an even number" : "an odd number";

            return even;
        }

        static string PosOrNeg(int anyGivenNumber)
        {

            string masMenos = (anyGivenNumber > 0) ? "I'm Positive that is Positive" : "why so Negative?";
            return masMenos;
        }

        static string CanTheyVote(int age)
        {
            string votingAge = (age >= 18) ? "you can vote if you've registered" : "not old enough to vote";
            return votingAge;
        }

        static string InAbsValOf10(int anyGivenNumber)
        {
            string withinRange = (anyGivenNumber > -11 && anyGivenNumber < 11) ? "it's within the absolute value of 10" : "it's outside the absolute value of 10";
            return withinRange;
        }

        static bool Multiply(int anyGivenNumber)
        {
            for (int MultByThis = 1; MultByThis <=12; MultByThis++)
            {
                int answer = anyGivenNumber * MultByThis;
                Console.WriteLine($"{anyGivenNumber} times {MultByThis} equals {answer}.");

            }
            return false;
        }

        static void Main(string[] args)
        {
            //Lukewarm 1
            bool ones = true;
            while (ones == true) {ones = Program.ShowAbsValOf1000(ones);}
            Console.WriteLine("\n \n \n");

            //Lukewarm 2
            bool threes = true;
            while (threes == true) {threes = Program.MultsOfThree(threes); }
            Console.WriteLine("\n \n \n");

            //Lukewarm 3
            Console.WriteLine("Give me a whole number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another whole number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.AreTheyEqual(num1, num2));
            Console.WriteLine("\n \n \n");

            //Lukewarm 4
            Console.WriteLine("Pick a number");
            int anyGivenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.EvenOrOdd(anyGivenNumber));
            Console.WriteLine("\n \n \n");

            //Lukewarm 5
            Console.WriteLine("give us a whole number that isn't 0");
            anyGivenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.PosOrNeg(anyGivenNumber));
            Console.WriteLine("\n \n \n");

            //Lukewarm 6
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.CanTheyVote(age));
            Console.WriteLine("\n \n \n");

            //Heatin up 1
            Console.WriteLine("Give me a number again");
            anyGivenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.InAbsValOf10(anyGivenNumber));
            Console.WriteLine("\n \n \n");

            //Heatin up 2
            Console.WriteLine("multiplication table for what number?");
            bool multiplying = true;
            anyGivenNumber = Convert.ToInt32(Console.ReadLine());
            while (multiplying == true)
            {
                multiplying = Program.Multiply(anyGivenNumber);
                Console.WriteLine("\n \n \n");
                
            }

            //Heatin up 3

        }
    }
}
