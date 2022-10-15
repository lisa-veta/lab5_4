using System;
namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество чисел в массиве: ");
            int count = int.Parse(Console.ReadLine());
            double[] numbers = new double [count];

            Console.Write($"Введите массив из {count} элементов через пробел: ");
            string[] str = Console.ReadLine().Split(' ');

            for (int i = 0; i < count; i++)
            {
                numbers[i] = double.Parse(str[i]);
            }

            foreach (double num in numbers)
                Console.Write(num + " ");
                
            
        }
    }
}
