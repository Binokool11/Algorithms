namespace Algorithms
{
    public class BaseSort<T> : ISort<T>
    {
        private ISort<T> objectSort { get; set; }
        protected List<T> collection {get;set;}

        public BaseSort() { }

        public BaseSort(List<T> collection)
        {
            if (collection != null)
            {
                this.collection = collection;
            }
            else
            {
                throw new ArgumentNullException(nameof(collection));
            }
        }

        public void SetSort(ISort<T> objectSort)
        {
            this.objectSort = objectSort;
        }

        public virtual void Sort()
        {
            try
            {
                if (objectSort != null)
                {
                    objectSort.Sort();
                    return;
                }
                throw new ArgumentNullException();
            }
            finally
            {
                Console.WriteLine("Sort is null");
            }
        }

        protected void Swap(List<T> collection,int left,int right)
        {
            T current = collection[left];
            collection[left] = collection[right];
            collection[right] = current;
        }
    }
}
