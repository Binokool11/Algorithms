using Algorithms;
using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestAlgorithm
{
    [TestClass]
    public class TestAlgorithms
    {
        const int minValue = 0;
        const int maxValue = 10;
        const int length = 10;
        [TestMethod]
        public void SelectionSortTest()
        {
            //arrange
           
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            BaseSort<int> baseSort = new BaseSort<int>();
            baseSort.SetSort(new SelectionSort<int>(collection));
            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void InsertSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new InsertSort<int>(collection));
            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void RedixSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new RedixSort<int>(collection));
            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void BubleSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new BubleSort<int>(collection));
            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void CombSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new CombSort<int>(collection));

            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void QuickSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new QuickSort<int>(collection));

            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void CocktailSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new CocktailSort<int>(collection));

            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void MergeSortTest()
        {
            //arrange
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new MergeSort<int>(collection));
            //act
            expected.Sort();
            baseSort.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void BaseSortTest()
        {
            //arrange
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            //act
            expected.Sort();
            collection.Sort();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
    }
}