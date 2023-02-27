namespace Algorithms.Sort
{
    public class BubleSort<T> : BaseSort<T> where T : IComparable
    {
        public BubleSort(List<T> collection) : base(collection) { } 
        public override void Sort()
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            int maxLength = collection.Count - 1;

            while (maxLength > 0) 
            { 
                for (int j = 0; j < maxLength; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) > 0)
                    {
                        Swap(collection,j,j+1);
                    }
                }
                maxLength--;
            }
        }
    }
}
