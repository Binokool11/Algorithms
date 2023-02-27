namespace Algorithms.Sort
{
    public class RedixSort<T> : BaseSort<T> where T : IComparable
    {

        public RedixSort(List<T> collection) : base(collection) { }

        public override void Sort()
        {
            Console.WriteLine(nameof(T));
            List<List<T>> items = new List<List<T>>(10);
            for (int i = 0; i < 10; i++)
            {
                items.Add(new List<T>());
            }

            int maxLength = GetMaxLength();
            int currentValue = 0;   

            for (int step = 0; step < maxLength; step++)
            {


                for (int i = 0; i < collection.Count; i++)
                {
                    currentValue = (collection[i].GetHashCode() % (int)Math.Pow(10 , step + 1)) / (int) Math.Pow(10 , step);
                    items[currentValue].Add(collection[i]);
                }


                collection.Clear();


                foreach (var item in items)
                {
                    foreach (var value in item)
                    {
                        collection.Add(value);
                    }
                }


                foreach (var item in items)
                {
                    item.Clear();
                }
            }
        }


        private int GetMaxLength()
        {
            int maxLength = 0;
            int currentLength = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                if(collection[i].GetHashCode() < 0)
                {
                    throw new ArgumentOutOfRangeException("Поразрядная сортировка работает только с числами больше нуля включительно");
                }
                currentLength = (int) (Math.Log10(collection[i].GetHashCode()) + 1);
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            return maxLength;
        }
    }
}
