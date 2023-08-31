using System;
using class_calculator;


namespace calculat_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operation1 obj = new Operation1();


            int n, m;

            Console.WriteLine("\t please enter first number ......!");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("\t please enter second number......!");
            int.TryParse(Console.ReadLine(), out m);





            Console.WriteLine("\t Select the operation");
            Console.WriteLine("\t + - add");
            Console.WriteLine("\t - - Minus");
            Console.WriteLine("\t * - Multiply");
            Console.WriteLine("\t /- Divide");
            Console.WriteLine("\t Your Operation?");

            string operand = Console.ReadLine();
            while (true)
            {


                switch (operand)
                {

                    case "+" or "sum":

                        Console.WriteLine($" {n}+{m} = " + obj.Sum(n, m));
                        break;
                    case "-" or "minuse":
                        Console.WriteLine($" {n}-{m} = " + obj.Minus(n, m));
                        break;
                    case "*" or "multiple":
                        Console.WriteLine($" {n}*{m} = " + obj.Multiple(n, m));
                        break;
                    case "/" or "divide":
                        Console.WriteLine($" {n}/{m} = " + obj.Divide(n, m));
                        break;

                    default:
                        Console.WriteLine("\t the operand is wrong...");
                        break;


                }
                Console.ReadKey();
            }
        }
    }
}