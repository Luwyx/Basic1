using System;

namespace Basic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling the Multi3 method and printing the result
            Console.WriteLine(Multi3(2, 4, 5));

            // Calling the CtoF method with different temperature values and printing the results
            Console.WriteLine(CtoF(0));
            Console.WriteLine(CtoF(100));
            Console.WriteLine(CtoF(-300));

            // Calling the EleOut method and printing the result
            Console.WriteLine(EleOut(3, 8));

            // Calling the IsResultTheSame method with arithmetic operations and printing the results
            Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            Console.WriteLine(IsResultTheSame(9 / 3, 16 - 1));

            // Calling the ModuloOperations method and printing the result
            Console.WriteLine(ModuloOperations(8, 5, 2));

            // Calling the TheCubeOf method with different numbers and printing the results
            Console.WriteLine(TheCubeOf(2));
            Console.WriteLine(TheCubeOf(-5.5));

            // Calling the SwapTwoNumbers method with different values and printing the results
            Console.WriteLine(SwapTwoNumbers(87, 45));
            Console.WriteLine(SwapTwoNumbers(-13, 2));
        }

        // Method to perform the operation (a + b) * c
        public static int Multi3(int a, int b, int c)
        {
            return (a + b) * c;
        }

        // Method to convert Celsius to Fahrenheit, with handling for below absolute zero
        public static string CtoF(double cel)
        {
            if (cel < -271.15)
            {
                return "Temperature is below absolute zero";
            }
            else
            {
                return ((cel * 1.8) + 32).ToString();
            }
        }

        // Method to calculate and return the results of addition, subtraction, multiplication, and division
        public static string EleOut(double a, double b)
        {
            double add = a + b;
            double sub = a - b;
            double mul = a * b;
            double div = a / b;

            string add2 = add.ToString();
            string sub2 = sub.ToString();
            string mul2 = mul.ToString();
            string div2 = div.ToString();

            string allres = add2 + ", " + sub2 + ", " + mul2 + ", " + div2;

            return allres;
        }

        // Method to check if two arithmetic results are the same, within a tolerance
        public static bool IsResultTheSame(double a, double b)
        {
            double result1 = a;
            double result2 = b;

            // Comparing the results with a tolerance using double.Epsilon
            if (Math.Abs(result1 - result2) < double.Epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to perform modulo operations on three integers
        public static int ModuloOperations(int a, int b, int c)
        {
            int result = (a % b) % c;
            return result;
        }

        // Method to calculate the cube of a number
        public static double TheCubeOf(double num)
        {
            double cube = num * num * num;
            return cube;
        }

        // Method to swap two numbers using a temporary variable
        public static string SwapTwoNumbers(int a, int b)
        {
            // Before swapping
            string before = $"Before: a = {a}, b = {b}";

            // Swapping using temporary variable
            int temp = a;
            a = b;
            b = temp;

            // After swapping
            string after = $"After: a = {a}, b = {b}";

            return before + "; " + after;
        }
    }
}
