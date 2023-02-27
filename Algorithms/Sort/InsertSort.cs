namespace Algorithms.Sort
{
    public class InsertSort<T> : BaseSort<T> where T : IComparable
    {
        public InsertSort(List<T> collection) : base(collection) { }

        public override void Sort()
        {

            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            int j = 0;
            int length = collection.Count;

            for (int i = 1; i < length; i++)
            {
                j = i;
                for (int count = j - 1; count >= 0; count--)
                {
                    if (collection[j].CompareTo(collection[count]) < 0)
                    {
                        Swap(collection,j,count);
                        j--;
                        
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
