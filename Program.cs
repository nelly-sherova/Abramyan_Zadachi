﻿using System;

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
            }
            {
                Console.Write("Задание 20\nx1 = "); double x1 = Convert.ToDouble(Console.ReadLine());  Console.Write("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine()); Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine()); Console.Write("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine()); Console.Write($"r = {Math.Pow((Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)),0.5)}"); 
            }
            {
                Console.Write("Задание 21\nx1 = ");double x1 = Convert.ToDouble(Console.ReadLine());  Console.Write("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine()); Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine()); Console.Write("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine()); Console.Write("x3 = "); double x3 = Convert.ToDouble(Console.ReadLine()); Console.Write("y3 = "); double y3 = Convert.ToDouble(Console.ReadLine()); double a, b, c; a = Math.Pow(((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)),0.5); b = Math.Pow(((x2-x3)*(x2-x3)+(y2-y3)*(y2-y3)),0.5); c = Math.Pow(((x1-x3)*(x1-x3)+(y1-y3)*(y1-y3)),0.5); double P = a + b + c ; double p = P/2; Console.WriteLine($"P = {P}\np = {p}\nS = {Math.Pow((p*(p-a)*(p-b)*(p-c)),0.5)}");
            }
            {
                Console.Write("Задание 22\nA = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"a = {a} , b = {b}"); a = a + b; b = a - b; a = a - b; Console.WriteLine($"new a and b : \na = {a} , b = {b} ");
            }
            {
                Console.Write("Задание 23\nA = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine()); Console.Write("C = "); double c = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"a = {a}, b = {b} , c = {c}"); a = a + b + c ; c = a - b - c; b = a - b - c; a = a - b - c; Console.WriteLine($"new a, b, c\na -> b -> {a}\nb -> c -> {b}\nc -> a -> {c}"); 
            }
            {
                Console.Write("Задание 24\nA = "); double a = Convert.ToDouble(Console.ReadLine()); Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine()); Console.Write("C = "); double c = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"a = {a}, b = {b} , c = {c}"); a = a + b + c ; b = a - b - c; c = a - b - c; a = a - b - c; Console.WriteLine($"new a, b, c\na -> c -> {a}\nb -> a -> {b}\nc -> b -> {c}"); 
            }
            {
                Console.Write("Задание 25\ny = 3·x^6 – 6·x^2 – 7\nx = "); double x = Convert.ToDouble(Console.ReadLine()); double y = 3 * Math.Pow(x,6) - 6 * x*x - 7; Console.WriteLine($"y({x}) = {y}");
            }
            {
                Console.Write("Задание 26\ny = 4·(x–3)^6 – 7·(x–3)^3 + 2\nx = "); double x = Convert.ToDouble(Console.ReadLine()); double y = 4 * Math.Pow((x-3),6) - 7 * Math.Pow((x-3),3) + 2; Console.WriteLine($"y = {y}");
            }
            {
                Console.Write("Задание 27\nA = "); double a = Convert.ToDouble(Console.ReadLine()); double a2, a4, a8; a2 = a*a; a4 = a2*a2; a8 = a4 * a4; Console.WriteLine($"{a}^8 = {a8}");
            }
            {
                Console.Write("Задание 28\nA = "); double a = Convert.ToDouble(Console.ReadLine()); double a2, a3, a5, a10, a15; a2 = a * a; a3 = a2 * a; a5 = a2 * a3; a10 = a5 * a5; a15 = a10* a5; Console.WriteLine($"{a}^15 = {a15}");  
            }
            {
                Console.Write("Задание 29\n(0 < l < 360)\nl = "); double l = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"{l} градусов это {l/57,3} радиан");
            }
            {
                Console.Write("Задание 30\n(0 < radian < 2*pi)\nradian = "); double r = Convert.ToDouble(Console.ReadLine()); Console.WriteLine($"{r} радианов это {r*57,3} градусов");
            }
        }
    }
}
