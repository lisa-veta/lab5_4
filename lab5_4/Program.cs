using System;
using System.Text;

namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество чисел в массиве: ");
            int count = int.Parse(Console.ReadLine());
            double[] numbers = new double[count];

            Console.Write($"Введите массив из {count} элементов через пробел: ");
            string[] str = Console.ReadLine().Split(' ');

            for (int i = 0; i < count; i++)
            {
                numbers[i] = double.Parse(str[i]);
            }

            double[] newNumbers = new double[count];

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] == Math.Truncate(numbers[i]) && numbers[i] >= 0)
                {
                    newNumbers[i] = CalculateFactorial(numbers[i]);
                }
                else
                {
                    newNumbers[i] = RoundToHundredths(numbers[i]);
                }
            }
            Console.WriteLine("\nВведенный массив: {0}", String.Join(" ", numbers));
            Console.WriteLine("\nПолученный массив: {0}", String.Join(" ", newNumbers));

        }

        public static double RoundToHundredths(double a)
        {
            double result = Math.Round(a, 2);

            if (Convert.ToInt32(result) == result)
            {
                return 0;
            }
            else
            {
                string[] subs = result.ToString().Split(',');

                if (subs[1][0] == '0')
                {
                    return (int)Char.GetNumericValue(subs[1][1]);
                }
                else
                {
                    return int.Parse(subs[1]);
                }
            }
        }

        public static long CalculateFactorial(double fact)
        {
            double h1 = fact;
            long h2 = 1;

            if (fact == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= h1; i++)
                {
                    h2 *= i;
                }
            }

            return h2;
        }
    }
}
