//zadanie 1

using ConsoleApp1;
using System.ComponentModel.DataAnnotations;
using System;
using System.Globalization;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double QuadraticEquation(double x, double a, double b, double c)
            {
                double wynik = a * x * x + b * x + c * c;
                return wynik;
            }
            Console.WriteLine(QuadraticEquation(0.0, 1.0, 1.0, 1.0));

            //zadanie 2

            void Swap(ref double a, ref double b)
            {
                double c = a;
                a = b;
                b = c;
            }
            double x = 11;
            double y = 22;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            //zadanie 3

            double[] matrix = { 1, 2, 3 };
            Console.WriteLine(Multiplier.Multiply(1, 2));
            Console.WriteLine(Multiplier.Multiply(1, 2, 3));
            Console.WriteLine(Multiplier.Multiply(matrix));

            // zadanie 4
            DayOfTheWeek a = DayOfTheWeek.Monday;
            Console.WriteLine($"Integral value of {a} is {(int)a}");
enum DayOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        //zadanie 5
        string DateTime1(DateTime dateTime)
        {
            string string1 = $"{dateTime.Day} {dateTime.Month} {dateTime.Year} {dateTime.Hour}:{dateTime.Minute}:{dateTime.Second} {dateTime.DayOfWeek}";
            return string1;
        }
        //zadanie 6
        double DevideBy (double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot devide by 0");
            else
                return a / b;
        }
        //zadanie 7
        void SetYourNewPassword (string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("No password entered");
            if (password.Length < 10)
                throw new FormatException("Password must be longer than 0");
            int upper = 0;
            int lower = 0;
            int symbol = 0;
            int digit = 0;
            foreach (char c in password)
            {
             
                if (char.IsUpper(c))
                    upper++;
                if (char.IsLower(c))
                    lower++;
                if (char.IsSymbol(c))
                    symbol++;
                if (char.IsDigit(c))
                    digit++;
            }
            if (upper == 0)
                throw new FormatException("Password must contain at least 1 uppercase letter, 1 lowercase letter, 1 special symbol and 1 digit");

        }
    }
}