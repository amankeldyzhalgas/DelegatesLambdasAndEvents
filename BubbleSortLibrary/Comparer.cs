﻿// <copyright file="Comparer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Реализует Icomparer.
    /// </summary>
    public class Comparer : IComparer<int[]>
    {
        private static IStrategy Strategy { get; set; }

        private Func<int[], int[], int> ComparerFunc { get; set; }

        private bool ByAscending { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comparer"/> class.
        /// </summary>
        /// <param name="strategy">strategy.</param>
        /// <param name="byAscending">byAscending.</param>
        public Comparer(IStrategy strategy, bool byAscending)
        {
            Strategy = strategy;
            this.ByAscending = byAscending;
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
            if (ReferenceEquals(x, y))
            {
                return 0;
            }
            else if (x is null)
            {
                return 1;
            }
            else if (y is null)
            {
                return -1;
            }

            var first = Strategy.Algorithm(x);
            var second = Strategy.Algorithm(y);

            if (first == second)
            {
                return 0;
            }

            if (this.ByAscending)
            {
                if (first > second)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (first < second)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
