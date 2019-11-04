// <copyright file="BubbleSort.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Класс для пузырковой сортировки массивов.
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// Метод "пузырьковой" сортировки для целочисленного массива.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="comparerFunc">Реализация для сравнении элементов.</param>
        /// <returns>Отсортированный массив.</returns>
        public static int[][] SortWithDelegate(int[][] array, Func<int[], int[], int> comparerFunc)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (comparerFunc is null)
            {
                throw new ArgumentNullException(nameof(comparerFunc));
            }

            return Sort(array, new Adapter(comparerFunc));
        }

        /// <summary>
        /// Метод "пузырьковой" сортировки для целочисленного массива.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="comparer">Реализация для сравнении элементов.</param>
        /// <returns>Отсортированный массив.</returns>
        public static int[][] Sort(int[][] array, IComparer<int[]> comparer)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (comparer is null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            bool isSorted = false;
            int count = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = array.Length - 1; i > count; i--)
                {
                    if (comparer.Compare(array[i], array[i - 1]) < 0)
                    {
                        Swap(ref array[i], ref array[i - 1]);
                        isSorted = false;
                    }
                }

                count++;
            }

            return array;
        }

        /// <summary>
        /// Меняет местами два индекса в массиве.
        /// </summary>
        /// <param name="first">Первый индекс.</param>
        /// <param name="second">Второй индекс.</param>
        private static void Swap(ref int[] first, ref int[] second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
