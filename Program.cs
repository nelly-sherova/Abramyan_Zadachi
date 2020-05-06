using System;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            /*{
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
            {
                Console.Write("Задание 10\na = "); double a = Convert.ToDouble(Console.ReadLine());Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"{a} + {b} = {a+b}\n{a} - {b} = {a - b}\n{a} * {b} = {a*b}\n{a}^2 + {b}^2 = {Math.Pow(a,2) + Math.Pow(b,2)}");
            }
            {
                Console.Write("Задание 11\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"{a} + {b} = {a+b}\n{a} - {b} = {a - b}\n{a} * {b} = {a*b}\n|{a}| + |{b}| = {Math.Abs(a)+Math.Abs(b)}");
            }
            {
                Console.Write("Задание 12\na = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine()); double c; c = Math.Pow((Math.Pow(a,2)+Math.Pow(b,2)),0.5); Console.WriteLine($"c = {c}\nP = {a+b+c}");
            }
            {
                Console.Write("Задание 13\n(R1>R2)\nR1 = "); double r1 = Convert.ToDouble(Console.ReadLine()); Console.Write("R2 = "); double r2 = Convert.ToDouble(Console.ReadLine()); const double pi = 3.14; double r3;  double s1, s2, s3; s1 = pi*r1*r1; s2 = pi*r2*r2; s3 = s1 - s2; Console.WriteLine($"S1 = {s1}\nS2 = {s2}\nS3 = {s3}"); 
            }
            {
                Console.Write("Задание 14\nL = "); double l = Convert.ToDouble(Console.ReadLine()); const double pi = 3.14; double r; r = l/2*pi; Console.WriteLine($"R = {r}\nS = {pi*r*r}");
            }
            {
                Console.Write("Задание 15\nS = "); double s = Convert.ToDouble(Console.ReadLine()); const double pi = 3.14; double d; d = Math.Pow((s*4/pi),0.5); Console.WriteLine($"D = {d}\nL = {pi*d}");
            }
            {
                Console.Write("Задание 16\nx1 = "); double x1 = Convert.ToDouble(Console.ReadLine()); Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"|{x2}-{x1}|= {Math.Abs(x2 - x1)}");
            }
            {
                Console.Write("Задание 17\nA = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine()); Console.Write("C = "); double c = Convert.ToDouble(Console.ReadLine()); double ac = Math.Abs(c - a); double bc = Math.Abs(c - b); Console.WriteLine($"AC = {ac}\nBC = {bc}\nAB + BC = {ac + bc}");
            }
            {
                Console.Write("Задание 18\n(A<C<B)\nA = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("C = "); double c = Convert.ToDouble(Console.ReadLine()); Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"AC*BC = {Math.Abs(c-a)*Math.Abs(b-a)}");
            }
            {
                Console.Write("Задание 19\nx1 = "); double x1 = Convert.ToDouble(Console.ReadLine());  Console.Write("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine()); Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine()); Console.Write("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"P = {2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1))}");
            }*/
            {
                Console.Write("Задание 20\nx1 = "); double x1 = Convert.ToDouble(Console.ReadLine());  Console.Write("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine()); Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine()); Console.Write("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine()); Console.Write($"r = {Math.Pow((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)),0.5)}");
                
            }
        }
    }
}
