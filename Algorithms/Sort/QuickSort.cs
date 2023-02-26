namespace Algorithms.Sort
{
    public class QuickSort<T> : BaseSort<T> where T : IComparable
    {
        public QuickSort(List<T> collection) : base(collection) { }

        public override void Sort()
        {
            QuickSortWrapper(collection,0,collection.Count - 1);
        }
        private void QuickSortWrapper(List<T> collection,int first, int last)
        {
            if (first >= last)
            {
                return;
            }
            int wall = first;
            for (int i = first; i < last; i++)
            {
                if (collection[last].CompareTo(collection[i]) > 0)
                {
                    Swap(collection,wall,i);
                    wall++;
                }
            }
            Swap(collection,wall,last);
            QuickSortWrapper(collection,first,wall - 1);
            QuickSortWrapper(collection,wall + 1,last);



        }
    }
}
