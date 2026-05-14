namespace MyInsertionSort
{
    public class MyInsertionSort<T>
        where T : IComparable<T>
    {


        public void Sort(T[] items)
        {
            for (int i = 0; i < items.Length-1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (CompareTo(items[i], items[j]) < 0)
                    {
                        Swap(items, i, j);
                    }
                }
            }
        }
        public int CompareTo(T Value, T other)
        {
            return Value.CompareTo(other);
        }

        private void Swap(T[] items, int v, int i)
        {
            T temp = items[i];
            items[i] = items[v];
            items[v] = temp;
        }
    }
}


