namespace Algorithms
{
    public static class GenerateValueCollection
    {
        public static void GenerateValue(List<int> collection, int minValue, int maxValue)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            if (minValue > maxValue)
            {
                throw new Exception("Не верно заданный диапозон");
            }
            Random random = new Random();
            for (int i = 0; i < collection.Capacity; i++)
            {
                collection.Add(random.Next(minValue, maxValue));
            }
        }
    }
}
