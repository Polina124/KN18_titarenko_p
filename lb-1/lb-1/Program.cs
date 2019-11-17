using System;

namespace lb_1
{
    class Program
    {
        static int GetVarOfCalc()
        {
            Console.WriteLine("Выберите калькулятор: \n1)Стандартный \n2)Инженерный \n3)Справка ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        
        }
        static void Main(string[] args)
        {
            Calculator calculator;
            var variant = GetVarOfCalc();
            if (variant == 1)
            {
                calculator = new CasualCalculator();
                Calls.CasualCalcCall(calculator);
            }
            else if (variant == 2)
            {
                calculator = new EngineerCalculator();
                Calls.EngCalcCall(calculator);
            }
            else
            {
                Calls.Help();
                return;
            }
            Saver.SaveResult(calculator.Result);
            Console.Read();
        } 
    }
}

