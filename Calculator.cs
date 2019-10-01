using System;

namespace Calculator_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            while (true)
            {
                double a, b, c; char h; c = 0.0;
                Console.WriteLine("Введите первое число "); a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию (+) (-) (*) (/) "); h = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число "); b = Convert.ToDouble(Console.ReadLine());
                switch (h)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                    case '*':
                        c = a * b;
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("= " + c);
                Console.WriteLine("Начать заново? (y/n)");
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.KeyChar == 'n') break;
                Console.WriteLine();

            }

        }
    }
}