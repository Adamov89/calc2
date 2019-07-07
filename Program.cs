using System;

namespace Calcalator
{
    class Calculator
    {
        public static double Dooperation(double a, double b, string h)
        {
            double c = double.NaN;

            switch (h)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "/":
                    if (a != 0)
                    {
                        c = a / b;
                    }
                    break;
                case "*":
                    c = a * b;
                    break;
            }
            return c;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            //bool endApp = false;

            Console.WriteLine("Кулькулятор");
            while (true)
            {


                double a, b, c; char h; c = 0.0;
                Console.WriteLine("ввести первое число"); a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ввести оператор (+) (-) (*) (/) "); h = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("ввести второе число"); b = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine();
                Console.WriteLine("= " + c);
                Console.WriteLine("Начать заново? (y/n)");
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.KeyChar == 'n') break;
                Console.WriteLine();

                //Console.WriteLine("Нажмите 'q' и Enter закрыть приложение, или нажмите любую другую клавишу и Enter, чтобы продолжить: ");
                //if (Console.ReadLine() == "q") endApp = true;
            }
        }
                
    }
}
