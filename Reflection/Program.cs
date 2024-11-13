using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Sub(double a, double b)
        {
            return a - b;
        }

        private static double Mult(double a, double b)
        {
            return a * b;
        }

        private static double Div(double a, double b)
        {
            return a / b;
        }

        public static double Calculator(double a, double b, string action)
        {
            // typeof используется для получения объекта System.Type, 
            // который содержит описание типа (класса, структуры, делегата, перечисления, интерфейса)
            Type type = typeof(Program);
            // MethodInfo обнаруживает атрибуты метода и обеспечивает доступ к его метаданным
            MethodInfo info = type.GetMethod(action, BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Static);
            // Вызываем метод (Add, Sub, Mult, Div)
            double result = (double)info?.Invoke(null, [a, b]);
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
                try
                {
                    double result = Calculator(a, b, action);
                    Console.WriteLine("Результат: " + result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный выбор!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
