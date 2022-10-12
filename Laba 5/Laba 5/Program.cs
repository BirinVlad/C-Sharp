using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(10);
                }
            }
            return result;
        }
        static void Main(string[] args)

        {
            int q = 0, k = 0;
            int min = 0;
            Console.WriteLine("Введiть кiлькiсть рядкiв : ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовпцiв : ");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("\t");
            var myArray = GetRandomArray(rows, columns);

            int indexMaxElement = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Console.Write($"{myArray[i, j]}\t");

                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                int maxElement = myArray[i, 0];
                int minElement = myArray[i, 0];
                maxElement = myArray[i, 0]; min = maxElement;
                for (int j = 0; j < columns; j++)
                {
                    if (myArray[i, j] > maxElement) { maxElement = myArray[i, j]; k = j; };
                    if (myArray[i, j] < minElement) { minElement = myArray[i, j]; q = j; };
                }
                int t = myArray[i, k]; myArray[i, k] = myArray[i, q]; myArray[i, q] = t;
                Console.WriteLine("\nМаксимальний елемент \"{0}\" розташований в {1} стовбцi", maxElement, i + 1);
                Console.WriteLine("\nМiнiмальний елемент \"{0}\" розташований в {1} стовбцi", minElement, i + 1);
            }

            Console.ReadLine();
        }

    }
}

