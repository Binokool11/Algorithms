namespace Algorithms.Sort
{
    public class SelectionSort<T> : BaseSort<T> where T : IComparable
    {
        public SelectionSort(List<T> collection) : base(collection) { }
        public override void Sort()
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            int min;
            for (int i = 0; i < collection.Count; i++)
            {
                min = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[min]) < 0)
                    {
                        min = j;
                    }
                }
                Swap(collection,i, min);
            }
        }
    }
}
