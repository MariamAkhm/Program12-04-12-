using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static int[] ViborSort(int[] mas)
        {

            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка вставками
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }
        static int[] ShellSort(int[] array)
        {
            //расстояние между элементами, которые сравниваются
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество чисел для сортировки.");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[numbers];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            ViborSort(mas);
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Сортировка вставками");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", InsertionSort(array)));
            Console.ReadLine();

            Console.WriteLine("Сортировка Шелла");
            Console.Write("Введите элементы массива: ");
            var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            array = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                array[i] = Convert.ToInt32(s[i]);
            }

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", ShellSort(array)));
            Console.ReadLine();

            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int n = arr.Length;
            HeapSort ob = new HeapSort();
            ob.Sort(arr);
            Console.WriteLine("Осортированный массив:");
            ob.PrintArray(arr);
        }
    }
}
