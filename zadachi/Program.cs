using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachi
{
    internal class Program
    {
        public static double Statistics(ref double product, out double average, params int[] numbers)
        {
            double sum = 0;
            product = 1;
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }

            average = numbers.Length > 0 ? sum / numbers.Length : 0; // Обработка случая, когда array пустой
            return sum; // Возвращаем сумму
        }
           // Метод для вывода массива
            static void Massive(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1 ");
            Random random = new Random();
            int[] numbers = new int[20];
            // Заполнение массива случайными числами
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); // Случайные числа от 1 до 100
            }
            // Вывод исходного массива
            Console.WriteLine("Исходный массив:");
            Massive(numbers);
            // Ввод двух чисел для обмена
            Console.WriteLine("Введите первое число из массива:");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Введите второе число из массива:");
            string secondInput = Console.ReadLine();
            // Преобразование введенных строк в числа
            if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
            {
                // Поиск индексов введенных чисел
                int firstIndex = Array.IndexOf(numbers, firstNumber);
                int secondIndex = Array.IndexOf(numbers, secondNumber);

                // Проверка, что оба числа найдены в массиве
                if (firstIndex != -1 && secondIndex != -1)
                {
                    // Меняем местами элементы
                    int temp = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temp;

                    // Вывод обновленного массива
                    Console.WriteLine("Обновленный массив:");
                    Massive(numbers);
                }
                else
                {
                    Console.WriteLine("Одно или оба введенных числа не найдены в массиве.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целые числа.");
            }
        }
        static void Task2()
        {
            Console.WriteLine("Задание 2 ");
            double average;
            double product = 1;
            double sum = Statistics(ref product, out average, 1, 2, 3, 4, 5);
            Console.WriteLine($"Сумма элементов: {sum}");
            Console.WriteLine($"Произведение элементов: {product}");
            Console.WriteLine($"Среднее арифметическое: {average}");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();            
        }
    }
}
