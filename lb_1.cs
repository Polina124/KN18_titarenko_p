using System;

namespace lb_1
{ 
    class Program
    {
        static int res = 0;
        static private string Operator = "placeholder";
        static private bool order = true;

        static private int GetResult(int num1, int num2, string Operator)
        {
            switch (Operator)
            {
                case "/":
                    return num1 / num2;
                case "*":
                    return num1 * num2;
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                default:
                    return 0;
            }
        }

        static public bool GetData()
        {
            if (order)
            {
                Console.WriteLine("Enter the operator: ");
                Program.Operator = Console.ReadLine();
                Program.order = false;
                if (Operator == "=")
                {
                    Console.WriteLine("The result is " + res);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Enter the next number: ");
                Program.res = GetResult(res, Convert.ToInt32(Console.ReadLine()), Operator);
                Program.order = true;
                return false;
            }
            return false;
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number: ");
            Program.res = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (GetData())
                    break;
            }
            Console.ReadLine();
        }
    }
}