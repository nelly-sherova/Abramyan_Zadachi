using System;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Задание 1\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"P = {4*a}");   
            }
            {
                Console.Write("Задание 2\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"S = {a*a}");
            }
            {
                Console.Write("Задание 3\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"P = {2*(a+b)}");
            }
            {
                Console.Write("Задание 4\nd = "); double d = Convert.ToDouble(Console.ReadLine()); const double pi = 3.14;  Console.WriteLine($"L = {pi*d}"); 
            }
            {
                Console.Write("Задание 5\na = "); double a = Convert.ToDouble(Console.ReadLine()); double v, s; v = Math.Pow(a,3); s = 6 * Math.Pow(a,2); Console.WriteLine($"V = {v}\nS = {s}"); 
            }
            {
                Console.Write("Задание 6\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); Console.Write("c = "); double c = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"V = {a*b*c}\nS = {2*((a*b)+(b*c)+(a*c))}");   
            }
            {
                Console.Write("Задание 7\nR = "); double r = Convert.ToDouble(Console.ReadLine()); const double pi = 3.14; Console.WriteLine($"L = {2*pi*r}\nS = {pi * Math.Pow(r,2)}");
            }
            {
                Console.Write("Задание 8\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"Sr = {(a+b)/2}");
            }
            {
                Console.Write("Задание 9\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"Sg = {Math.Pow((a*b),0.5)}");
            }
        }
    }
}
