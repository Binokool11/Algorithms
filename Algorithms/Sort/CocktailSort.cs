namespace Algorithms.Sort
{
    public class CocktailSort<T> : BaseSort<T> where T : IComparable
    {
        public CocktailSort(List<T> collection) : base(collection) { }
        public override void Sort()
        {
            int left = 0;
            int right = collection.Count - 1;
            int currentiIndex = 0;


            while(left < right)
            {
                currentiIndex = left;
                for (int i = left; i <= right; i++)
                {
                    if (collection[currentiIndex].CompareTo(collection[i]) < 0)
                    {
                        currentiIndex = i;
                    }
                }
                Swap(collection,currentiIndex,right);
                right--;
                currentiIndex = right;
                for (int j = right; j >= left; j--)
                {
                    if (collection[currentiIndex].CompareTo(collection[j]) > 0)
                    {
                        currentiIndex = j;
                    }
                }
                Swap(collection,left,currentiIndex);
                left++;
            }
        }
    }
}
