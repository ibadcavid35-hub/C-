using System;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
namespace Calculator
{
    class Program
    {
        public static double Add() {
            Console.Write("First number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x + y;
        }
        public static double Subt()
        {
            Console.Write("First number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x - y;
        }
        public static double Mult()
        {
            Console.Write("First number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return x * y;
        }
        public static double Div()
        {
            Console.Write("First number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("0-a bolmek olmaz.");
                return 0;
            }
            return x / y ;
        }
        static void Main(string[] args)
        {
            string emeliyyatlar = @"
+ => Toplama
- => Cixma
* => Vurma
/ => Bolme
e => Exit";
            Console.WriteLine(emeliyyatlar);
            bool run = true;
            while (run)
            {
                Console.Write("Emelliyati sec: ");
                char emel=Convert.ToChar(Console.ReadLine());
                switch (emel)
                {
                    case '+': Console.WriteLine($"Cem: {Add()}"); break;
                    case '-': Console.WriteLine($"Cem: {Subt()}"); break;
                    case '*': Console.WriteLine($"Cem: {Mult()}"); break;
                    case '/': Console.WriteLine($"Cem: {Div()}"); break;
                    case 'e': Console.WriteLine("Cixis etdiniz.."); run = false;break;
                    default: Console.WriteLine("Unknown"); break;
                }
            }

        }
    }
}