using System;

namespace Reflection
{
    class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            return a / b;
        }

        public static double Calculator(double a, double b, string action)
        {
            double result = 0;
            switch (action)
            {
                case "Add":
                    result = Add(a, b);
                    break;
                case "Sub":
                    result = Sub(a, b);
                    break;
                case "Mult":
                    result = Mult(a, b);
                    break;
                case "Div":
                    result = Div(a, b);
                    break;
                default:
                    throw new Exception("Некорректный выбор!");
            }
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                double a, b;
                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите действие (Add, Sub, Mult, Div): ");
                string action = Console.ReadLine();
                double result = Calculator(a, b, action);
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
