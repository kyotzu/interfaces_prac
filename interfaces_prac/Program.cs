using System;

namespace ConsoleCalculator
{
    public interface IAddition
    {
        double Add(double a, double b);
    }

    public class Calculator : IAddition
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAddition calculator = new Calculator();

            try
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = calculator.Add(num1, num2);

                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите числа.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Работа программы завершена.");
            }
        }
    }
}
