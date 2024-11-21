using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    internal class Program
    {
        // Рекурсивный метод для вычисления n-го числа Фибоначчи
        static int Fibonacci(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Позиция должна быть натуральным числом (больше 0).");
            if (n == 1 || n == 2)
                return 1; // Первые два числа Фибоначчи равны 1
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        // Метод для вычисления НОД двух чисел
        static int NOD(int a, int b)
        {
            if (b == 0)
                return a;
            return NOD(b, a % b);
        }
        // Метод для вычисления НОД трех чисел
        static int NOD(int a, int b, int c)
        {
            return NOD(NOD(a, b), c);
        }
        // Метод для вычисления факториала числа
        static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал не определен для отрицательных чисел.");
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
        // Рекурсивный метод для вычисления факториала числа
        static long RecursiveFactorial(int number)
        {
            // Проверка на отрицательное число
            if (number < 0)
            {
                throw new ArgumentException("Факториал не определен для отрицательных чисел.");
            }
            // Базовый случай: факториал 0 равен 1
            if (number == 0)
            {
                return 1;
            }
            // Рекурсивный случай
            return number * RecursiveFactorial(number - 1);
        }
            // Метод для вычисления факториала числа
            static bool Calculate(int number, out long factorial)
        {
            factorial = 1; // Инициализация выходного параметра
            // Проверка на отрицательное число
            if (number < 0)
            {
                return false; // Факториал отрицательного числа не определен
            }
            try
            {
                // Вычисление факториала  для отслеживания переполнения
                for (int i = 1; i <= number; i++)
                {
                    checked
                    {
                        factorial *= i; // Умножение с проверкой на переполнение
                    }
                }
                return true; // Успешное вычисление
            }
            catch (OverflowException)
            {
                return false; // Переполнение произошло
            }
        }
            // Метод, меняющий местами значения двух передаваемых параметров
            static void Return(ref int a, ref int b)
        {
            int temp = a; // Сохраняем значение a во временной переменной
            a = b;        // Присваиваем значение b переменной a
            b = temp;     // Присваиваем временное значение переменной b
        }
        // Метод, возвращающий наибольшее из двух целых чисел
        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static void Task1 ()
        {
            Console.WriteLine("Упражнение 5.1 ");
            // Тестирование метода Max
            Console.WriteLine("Тестирование метода Max:");
            // Пример 1
            int num1 = 6;
            int num2 = 8;
            Console.WriteLine($"Наибольшее из {num1} и {num2}: {Max(num1, num2)}");
            // Пример 2
            num1 = 25;
            num2 = 23;
            Console.WriteLine($"Наибольшее из {num1} и {num2}: {Max(num1, num2)}");
            // Пример 3
            num1 = -3;
            num2 = -7;
            Console.WriteLine($"Наибольшее из {num1} и {num2}: {Max(num1, num2)}");
            // Пример 4
            num1 = 0;
            num2 = 0;
            Console.WriteLine($"Наибольшее из {num1} и {num2}: {Max(num1, num2)}");
            // Пример 5
            num1 = 100;
            num2 = 100;
            Console.WriteLine($"Наибольшее из {num1} и {num2}: {Max(num1, num2)}");
        }
        static void Task2()
        {
            Console.WriteLine("Упражнение 5.2 ");
            // Тестирование метода 
            Console.WriteLine("Тестирование метода Return:");
            // Пример 1
            int num1 = 4;
            int num2 = 10;
            Console.WriteLine($"Перед обменом: num1 = {num1}, num2 = {num2}");
            // Вызов метода 
            Return(ref num1, ref num2);
            Console.WriteLine($"После обмена: num1 = {num1}, num2 = {num2}");
        }
        static void Task3()
        {
            Console.WriteLine("Упражнение 5.3");
            // Тестирование метода TryCalculateFactorial
            Console.WriteLine("Тестирование метода TryCalculateFactorial:");
            int number1 = 20; // Пример числа для вычисления факториала
            if (Calculate(number1, out long result1))
            {
                Console.WriteLine($"Факториал {number1} = {result1}");
            }
            else
            {
                Console.WriteLine($"Переполнение при вычислении факториала для {number1}");
            }
            // Пример с числом, при котором произойдет переполнение
            int number2 = 21;
            if (Calculate(number2, out long result2))
            {
                Console.WriteLine($"Факториал {number2} = {result2}");
            }
            else
            {
                Console.WriteLine($"Переполнение при вычислении факториала для {number2}");
            }
            // Дополнительный тест для отрицательного числа
            int number3 = -5;
            if (Calculate(number3, out long result3))
            {
                Console.WriteLine($"Факториал {number3} = {result3}");
            }
            else
            {
                Console.WriteLine($"Переполнение при вычислении факториала для {number3}");
            }
        }
        static void Task4() {
            Console.WriteLine(" Упражнение 5.4 ");
            // Тестирование метода RecursiveFactorial
            Console.WriteLine("Тестирование рекурсивного метода вычисления факториала:");
            int number = 5; // Пример числа для вычисления факториала
            long result = RecursiveFactorial(number);
            Console.WriteLine($"Факториал {number} = {result}");
            number = 0; // Проверка базового случая
            result = RecursiveFactorial(number);
            Console.WriteLine($"Факториал {number} = {result}");
            // Пример с отрицательным числом
            try
            {
                number = -3;
                result = RecursiveFactorial(number);
                Console.WriteLine($"Факториал {number} = {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Обработка исключения для отрицательных чисел
            }
        }
        static void Task5()
        {
            Console.WriteLine("Домашнее задание 5.1 ");
            // Пример использования метода для вычисления НОД
            int num1 = 48;
            int num2 = 18;
            int gcdTwo = NOD(num1, num2);
            Console.WriteLine($"НОД {num1} и {num2} = {gcdTwo}");

            int num3 = 24;
            int gcdThree = NOD(num1, num2, num3);
            Console.WriteLine($"НОД {num1}, {num2} и {num3} = {gcdThree}");

            // Пример использования метода для вычисления факториала
            int factorialNumber = 5;
            int factorialResult = Factorial(factorialNumber);
            Console.WriteLine($"Факториал {factorialNumber} = {factorialResult}");
        }
        static void Task6()
        {
            Console.WriteLine(" Домашнее задание 5.2 ");
            // Пример использования метода для вычисления n-го числа Фибоначчи
            int n = 7; // Например, 7-е число Фибоначчи
            int fibonacciResult = Fibonacci(n);
            Console.WriteLine($"Число Фибоначчи под номером {n} = {fibonacciResult}");
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();  
            Task4();    
            Task5(); 
            Task6();

            
        }
    }
}
