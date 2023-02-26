namespace Algorithms.Sort
{
    public class GnomeSort<T> : BaseSort<T> where T : IComparable
    {
        public GnomeSort (List<T> collection) : base(collection) { } 
        public override void Sort()
        {
            int j = 0;  
            for (int i = 0; i < collection.Count; i++)
            {
                for (int count = i + 1; count < collection.Count; count++)
                {
                    if (collection[i].CompareTo(collection[count]) > 0)
                    {
                        Swap(collection, i, count);
                        j = 0;
                        for (int k = i; k > 0; k--)
                        {
                            if (collection[k - 1].CompareTo(collection[i - j]) > 0)
                            {
                                Swap(collection, i - j, k - 1);
                                j++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    break;
                }
            }
        }
    }
    public class GnomeSortSecond<T> : BaseSort<T> where T : IComparable
    {
        public GnomeSortSecond(List<T> collection) : base(collection) { }
        public override void Sort()
        {
            int i = 1;
            while (i < collection.Count)
            {
                if (i > 0 && collection[i].CompareTo(collection[i - 1]) < 0)
                {
                    Swap(collection,i,i-1);
                    i--;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
