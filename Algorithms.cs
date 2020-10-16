using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab1
{
    class Algorithms
    {
        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <param name="mass">Принимает массив целых чисел</param>
        /// <param name="ascending">Bool; Когда истинна выполняет сортировку по неубыванию. Равен "True" по умолчанию</param>
        /// <returns>Возвращает отсортированный массив</returns>
        public static int[] Insertion_Sort(int[] mass, bool ascending = true) 
        {
            int key = 0;
            int i;
            
            for (int j = 1; j < mass.Length; j++)
            {
                key = mass[j];
                i = j - 1;

                if (ascending == true)
                {
                    while (i >= 0 && mass[i] > key)
                    {
                        mass[i + 1] = mass[i];
                        i = i - 1;
                    }
                    mass[i + 1] = key;
                }
                else
                {
                    while (i >= 0 && mass[i] < key)
                    {
                        mass[i + 1] = mass[i];
                        i = i - 1;
                    }
                    mass[i + 1] = key;
                }
            }

            return mass;            
        }

        /// <summary>
        /// Бинарный поиск 
        /// </summary>
        /// <param name="mass">Принимает массив целых чисел</param>
        /// <param name="required_obj">Искомое число</param>
        /// <returns>Возращает массив с 0:{Индекс искомого числа}, 1:{Искомое число}</returns>
        public static string[] SimpleSearch(int[] mass, int required_obj)
        {
            string[] answer = new string[1];

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == required_obj)
                    return answer =  new[] { i.ToString(), mass[i].ToString()};
            }

            return null;
        }

        /// <summary>
        /// Сортировка слиянием массива целых чисел
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <param name="lowIndex">Индекс начала сортиовки</param>
        /// <param name="highIndex">Индекс до которого будет выполняться сортировка</param>
        /// <returns>Возращает отсортированный массив</returns>
        public static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        /// <summary>
        /// Сортировка слиянием массива целых чисел
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Возращает отсортированный массив</returns>
        //public static int[] MergeSort(int[] array)
        //{
        //    return MergeSort(array, 0, array.Length - 1);
        //}

        /// <summary>
        /// Сортировка слиянием массива символов
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <param name="lowIndex">Индекс начала сортиовки</param>
        /// <param name="highIndex">Индекс до которого будет выполняться сортировка</param>
        /// <returns>Возращает отсортированный массив</returns>
        public static char[] MergeSort(char[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }
        /// <summary>
        /// Сортировка слиянием массива символов
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns>Возращает отсортированный массив</returns>
        //public static char[] MergeSort(char[] array)
        //{
        //    return MergeSort(array, 0, array.Length - 1);
        //}
                
        private static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
        private static void Merge(char[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new char[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }
                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}
