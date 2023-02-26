namespace Algorithms.Sort
{
    public class MergeSort<T> : BaseSort<T> where T : IComparable
    {
        public MergeSort(List<T> collection) : base(collection) { }

        public override void Sort()
        {
            var result = MergeSortApp(collection);
            collection.Clear();
            collection.AddRange(result);
        }

        private List<T> MergeSortApp(List<T> collection)
        {
            if (collection.Count == 1)
            {
                return collection;
            }
            int mid = collection.Count / 2;
            List<T> left = collection.Take(mid).ToList();
            List<T> right = collection.Skip(mid).ToList();
            return Merge(MergeSortApp(right),MergeSortApp(left));
        }

        private List<T> Merge(List<T> rigth, List<T> left)
        {
            int length = rigth.Count + left.Count;
            List<T> result = new List<T>(length);
            int leftIndex = 0;
            int rigthIndex = 0;
            for (int i = 0; i < length;)
            {
                if (leftIndex < left.Count && rigthIndex < rigth.Count)
                {
                    if (left[leftIndex].CompareTo(rigth[rigthIndex]) >= 0)
                    {
                        result.Add(rigth[rigthIndex]);
                        rigthIndex++;
                        i++;
                    }
                    else
                    {
                        result.Add(left[leftIndex]);
                        leftIndex++;
                        i++;
                    }
                }
                else
                {
                    if (leftIndex >= left.Count)
                    {
                        result.AddRange(rigth.Skip(rigthIndex));
                        break;
                    }
                    if (rigthIndex >= rigth.Count)
                    {
                        result.AddRange(left.Skip(leftIndex));
                        break;
                    }
                }
            }
            return result;
        }
    }
}
