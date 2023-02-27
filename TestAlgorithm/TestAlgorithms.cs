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
        const int length = 50000;
        [TestMethod]
        public void SelectionSortTest()
        {
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            BaseSort<int> baseSort = new BaseSort<int>();
            baseSort.SetSort(new SelectionSort<int>(collection));
            
            expected.Sort();
            baseSort.Sort();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void GnomeSortTest()
        {
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            BaseSort<int> baseSort = new BaseSort<int>();
            baseSort.SetSort(new GnomeSort<int>(collection));
            
            expected.Sort();
            baseSort.Sort();
            
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void InsertSortTest()
        {
            
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new InsertSort<int>(collection));
            
            expected.Sort();
            baseSort.Sort();
            
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void RedixSortTest()
        {
            
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new RedixSort<int>(collection));
            
            expected.Sort();
            baseSort.Sort();
            
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void BubleSortTest()
        {
            
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new BubleSort<int>(collection));
            
            expected.Sort();
            baseSort.Sort();
            
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void GnomeSortSecondTest()
        {
            
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new GnomeSortSecond<int>(collection));
            
            expected.Sort();
            baseSort.Sort();
            
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void CombSortTest()
        {
            
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new CombSort<int>(collection));

            expected.Sort();
            baseSort.Sort();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void QuickSortTest()
        {
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new QuickSort<int>(collection));

            expected.Sort();
            baseSort.Sort();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void CocktailSortTest()
        {
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new CocktailSort<int>(collection));

            expected.Sort();
            baseSort.Sort();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void MergeSortTest()
        {
            BaseSort<int> baseSort = new BaseSort<int>();
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);
            baseSort.SetSort(new MergeSort<int>(collection));

            expected.Sort();
            baseSort.Sort();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
        [TestMethod]
        public void BaseSortTest()
        {
            List<int> expected = new List<int>(length);
            GenerateValueCollection.GenerateValue(expected, minValue, maxValue);
            List<int> collection = new List<int>(expected);

            expected.Sort();
            collection.Sort();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], collection[i]);
            }
        }
    }
}