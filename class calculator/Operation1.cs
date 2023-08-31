using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_calculator
{
    public class Operation1
    {
        
        public int Sum(int n, int m)
        {

            return n + m;

        }
        public int Minus(int n, int m)
        {
            return n - m;


        }

        public double Multiple(int n, int m)
        {
            return n * m;
        }
        public double Divide(int n, int m)
        {

            try
            {

                return n / m;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide number by zero ");

                return 0;
            }
        }
    }
}