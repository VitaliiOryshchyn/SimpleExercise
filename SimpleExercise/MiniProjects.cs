using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExercise
{
    public class MiniProjects
    {
        private static bool isTrue = true;

        public static void StartProject() 
        {
            Console.WriteLine("In this project we have 5 excercise");
            while (isTrue)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Output name;\n2.Exchange of values of variables;\n3.The sum of the characters in the word;\n" +
                    "4.Heron formula calculator;\n5.Profile user and calculator body mass index;\n6.Find min and max number;\n" +
                    "7.Average calculator;\n8.Factorial calculator;\n9.Authentication;\n10.Exit");
                Console.WriteLine();
                Console.Write("Choose exercise(Enter a number from 1 to 6): ");

                int numberExcercise = thisIsNumber();


                switch (numberExcercise)
                {
                    case 1:
                        HomeWorkOne();
                        break;
                    case 2:
                        HomeWorkTwo();
                        break;
                    case 3:
                        HomeWorkThree();
                        break;
                    case 4:
                        HeronsFormula();
                        break;
                    case 5:
                        UserProfile();
                        break;
                    case 6:
                        MinMax();
                        break;
                    case 7:
                        AverageСalculator();
                        break;
                    case 8:
                        FactorialCalculator();
                        break;
                    case 9:
                        Authentication();
                        break;
                    case 10:
                        isTrue = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect number");
                        break;
                }
                Console.WriteLine();
            }
        }

        static int thisIsNumber()
        {
            int n;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("You entered an invalid number");
                Console.WriteLine("Try againe");
                Console.Write("Choose exercise(Enter a number from 1 to 6): ");
            }
            return n;
        }

        static void HomeWorkOne()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine();
        }

        static void HomeWorkTwo()
        {
            Console.WriteLine("Please, enter two number x and y!");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Process changing:");
            Console.WriteLine($"x = {(x + y) - x};\ny = {(x + y) - y};");
            Console.WriteLine();
        }

        static void HomeWorkThree()
        {
            Console.Write("Please enter number, that we calc length: ");
            string word = Console.ReadLine();
            Console.WriteLine($"Length this number {word} is {word.Length}");
            Console.WriteLine();
        }

        static void HeronsFormula()
        {
            Console.WriteLine("Please enter three value for sides a,b,c:");
            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Process calc P");
            double p = (a + b + c) / 2;
            Console.WriteLine($"P = {p}");
            Console.WriteLine("Process calc Heron's Fourmula(S)");
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Result S = {s}");
            Console.WriteLine();
        }

        static void UserProfile()
        {
            Console.WriteLine("User Profile:");
            Console.WriteLine("Please enter lastname, firstname, age, weight, height");
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Age: ");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            string profile = string.Format($"Your profile:\nFull Name: {lastname + " " + firstname}\n" +
                $"Age: {age}\nWeight: {weight}\nHeight: {height}\n" +
                $"Body Mass Index: {weight / (height * height)}");
            Console.WriteLine();
            Console.WriteLine(profile);
            Console.WriteLine();
        }

        static void MinMax()
        {
            Console.WriteLine("Please enter two number of type int:");
            Console.Write("Number 1 = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Number one bigger then number two");
            }
            else
            {
                Console.WriteLine("Number two bigger then number one");
            }
        }

        static void AverageСalculator()
        {
            Console.WriteLine("Enter 10 integer number:");
            double number;
            double summ = 0;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                number = Convert.ToDouble(Console.ReadLine());
                if (number != 0)
                {
                    summ += number;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            double result = summ / counter;
            Console.WriteLine(result);
        }

        static void FactorialCalculator()
        {
            Console.Write("Enter number for factoring: ");
            int numberFactoring = Convert.ToInt32(Console.ReadLine());
            int resultFactoring = 1;
            if (numberFactoring != 0 && numberFactoring != 1)
            {
                for (int i = 1; i <= numberFactoring; i++)
                {
                    resultFactoring *= i;
                }
                Console.WriteLine($"Result = {resultFactoring}");
            }
            else
            {
                Console.WriteLine("Result = 1");
            }
        }

        static void Authentication()
        {
            Console.WriteLine("Please enter Login and Password");
            Console.Write("Login: ");
            string correctLogin = Console.ReadLine();
            Console.Write("Password: ");
            string correctPassword = Console.ReadLine();
            string login;
            string password;
            int counter = 0;
            do
            {
                Console.Write("Please enter Login: ");
                login = Console.ReadLine().ToLower();
                Console.Write("Please enter Password: ");
                password = Console.ReadLine().ToLower();
                if (correctLogin == login && correctPassword == password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the System");
                    break;
                }
                else 
                {

                    Console.WriteLine("Incorect Login or Password");

                }
                counter++;
                Console.WriteLine();
            }
            while (counter < 3);
            if (counter == 3)
            {
                Console.WriteLine("The number of available tries have been exceeded");
            }
        }

    }
}
