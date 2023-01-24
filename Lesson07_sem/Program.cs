using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson07_sem
{
    class Program
    {
        static String divider = new String('=', 112);

        static int[,] Create2DArray( int x, int y )
        {
            int[,] array = new int[x, y];
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = i + j;
                }
            }
            return array;
        }

        static int[,] ChangeToSquare(int[,] _array)
        {
            int[,] localArray = _array.Clone() as int[,];            
            for (int i = 0; i < localArray.GetLength(0); i += 2 )
            {
                for (int j = 0; j < localArray.GetLength(1); j += 2)
                {
                    localArray[i, j] *= localArray[i, j];
                }
            }
            return localArray;
        }

        static int SumOfMainDiagonal( int[,] _array )
        {
            int sum = 0;
            int x = _array.GetLength(0) < _array.GetLength(1) ? _array.GetLength(0) : _array.GetLength(1);
            for (int k = 0; k < x; k++)
            {
                sum += _array[k, k];
            }
            return sum;
        }

        static void Show2DArray( int[,] array )
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,5},", array[i, j] );

                Console.WriteLine("]");
            }
            Console.WriteLine();
        }

        static void Main( string[] args )
        {

            //Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
            Console.Write("Введите число строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] newArray1 = Create2DArray(x: m, y: n);
            Show2DArray(newArray1);

            Console.WriteLine(divider);            

            //Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
            int[,] newArray2 = ChangeToSquare(newArray1);
            Show2DArray(newArray2);

            Console.WriteLine(divider);

            // Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.            
            Console.WriteLine("Сумма главной диагонали = {0}", SumOfMainDiagonal(newArray1));
            Console.WriteLine("Сумма главной диагонали = {0}", SumOfMainDiagonal(newArray2));
            Console.WriteLine(divider);

            Console.ReadKey();
        }
    }
}
