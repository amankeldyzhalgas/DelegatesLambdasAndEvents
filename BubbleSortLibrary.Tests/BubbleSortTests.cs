// <copyright file="BubbleSortTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary.Tests
{
    using System.Collections;
    using System.Collections.Generic;
    using NUnit.Framework;

    /// <summary>
    /// �������� ����� ��� BubbleSort.
    /// </summary>
    public class BubbleSortTests
    {
        /// <summary>
        /// ����� ��������� ���������� � ������� ����������� ���� ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortAscBySumOfNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortBySumOfNumbers(), true);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// ����� ��������� ���������� � ������� ����������� ���� ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortAscBySumOfNumbersTestsWithDelegate()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortBySumOfNumbers(), true);
            BubbleSort.SortWithDelegate(arr, comparer.Compare);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// ����� ��������� ���������� � ������� �������� ���� ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortDescBySumOfNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortBySumOfNumbers(), false);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// ����� ��������� ���������� � ������� ����������� ������������ ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortAscByMaxNumbersTestsTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortByMaxOfNumbers(), true);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// ����� ��������� ���������� � ������� �������� ������������ ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortDescByMaxNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 7, 9, 2, 3 }, new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortByMaxOfNumbers(), false);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// ����� ��������� ���������� � ������� ����������� ����������� ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortAscByMinNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 }, new int[] { 8, 3, 3, 7 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortByMinOfNumbers(), true);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// ����� ��������� ���������� � ������� �������� ����������� ��������� ����� �������.
        /// </summary>
        [TestCase]
        public void SortDescByMinNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer<int[]> comparer = new BubbleSortLibrary.Comparer(new SortByMinOfNumbers(), false);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }
    }
}