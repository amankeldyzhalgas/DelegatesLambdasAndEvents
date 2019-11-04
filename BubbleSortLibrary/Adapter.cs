// <copyright file="Adapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Класс Adapter.
    /// </summary>
    public class Adapter : IComparer<int[]>
    {
        private Func<int[], int[], int> ComparerFunc { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Adapter"/> class.
        /// </summary>
        /// <param name="comparerFunc">Реализация для сравнении элементов.</param>
        public Adapter(Func<int[], int[], int> comparerFunc)
        {
            this.ComparerFunc = comparerFunc;
        }

        /// <summary>
        /// Метод сравнивает два объекта.
        /// </summary>
        /// <param name="x">Первый объект.</param>
        /// <param name="y">Второй объект.</param>
        /// <returns>
        /// Возвращает '0', если объекты равны, '1', если первый  объект.
        /// больше второго и '-1', если второй объект больше первого.
        /// </returns>
        public int Compare(int[] x, int[] y)
        {
            return this.ComparerFunc(x, y);
        }
    }
}
