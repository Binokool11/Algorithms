namespace Algorithms.Sort
{
    public class CombSort<T> : BaseSort<T> where T : IComparable<T>
    {
        public CombSort(List<T> collection) : base(collection) { }
        const double factor = 1.247;
        public override void Sort()
        {
            int distance = collection.Count - 1;
            while (distance >= 1)
            {
                for (int j = 0; j + distance < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[j + distance]) > 0)
                    {
                        Swap(collection,j,j+distance);
                    }
                }
                distance = (int)(distance / factor);
            }
        }
    }
}
