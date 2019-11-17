using System;

namespace lb_1
{
    class Calls
    {
        public static void CasualCalcCall(Calculator calculator)
        {
            Console.WriteLine("Введите число:");
            calculator.Number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак:");
            string sign = Console.ReadLine();
            if (sign != "=")
                calculator.Sign = sign;
            else
            {
                Console.WriteLine("Ответ = " + calculator.Result);
                return;
            }
            CasualCalcCall(calculator);
        }

        public static void EngCalcCall(Calculator calculator)
        {
            Console.WriteLine("Введите функцию: ");
            calculator.Sign = Console.ReadLine();
            Console.WriteLine("Введите число: ");
            calculator.Number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ = " + calculator.Result);
        }

        public static void Help()
        {
            Console.WriteLine("1) Стандартный калькулятор может использовать +, -, *, /." +
                "\n Чтобы завершить вычисление введите *=* " +
                "\n2) Калькулятор имеет функции: cos, sin, tan, arccos, arcsin, sqrt, power, log, log10." +
                "\n Для завершения нажмите *ENTER*");
            Console.Read();
        }
    }
}
