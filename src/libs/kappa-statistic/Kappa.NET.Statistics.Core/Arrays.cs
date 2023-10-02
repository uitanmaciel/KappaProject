namespace Kappa.NET.Statistics.Core;

public static class Arrays
{
    public static void Sort<TKeys, TItems>(IList<TKeys> keys, IList<TItems> items, IComparer<TKeys> comparer = null)
    {
        if (keys.Count <= 1)
            return;

        if (comparer == null)
            comparer = Comparer<TKeys>.Default;

        if (keys.Count == 2)
        {
            if (comparer.Compare(keys[0], keys[1]) > 0)
            {
                Swap(keys, 0, 1);
                Swap(items, 0, 1);
            }
            return;
        }

        if (keys.Count <= 10)
        {
            for (int i = 1; i < keys.Count; i++)
            {
                var key = keys[i];
                var item = items[i]; 
                int j = i - 1;
                while (j >= 0 && comparer.Compare(keys[j], key) > 0)
                {
                    keys[j + 1] = keys[j];
                    items[j + 1] = items[j];
                    j--;
                }
                keys[j + 1] = key;
                items[j + 1] = item;
            }
            return;
        }
        
        if(keys is TKeys[] arrKeys && items is TItems[] arrItems) 
        { 
            Array.Sort(arrKeys, arrItems, comparer);
            return;
        }
        
        QuickSort(keys, items, comparer, 0, keys.Count - 1);
    }

    public static void QuickSort<TKeys, TItems>(IList<TKeys> keys, IList<TItems> items, IComparer<TKeys> comparer, int left, int right)
    {
        if (left >= right)
            return;

        int pivot = Partition(keys, items, comparer, left, right);

        QuickSort(keys, items, comparer, left, pivot - 1);
        QuickSort(keys, items, comparer, pivot + 1, right);
    }

    static int Partition<TKeys, TItems>(IList<TKeys> keys, IList<TItems> items, IComparer<TKeys> comparer, int left, int right)
    {
        int pivot = left;
        for (int i = left; i < right; i++)
        {
            if (comparer.Compare(keys[i], keys[right]) < 0)
            {
                Swap(keys, i, pivot);
                Swap(items, i, pivot);
                pivot++;
            }
        }
        Swap(keys, pivot, right);
        Swap(items, pivot, right);
        return pivot;
    }

    static void Swap<TKeys>(IList<TKeys> keys, int i, int j)
    {
        if (i == j)
            return;

        (keys[i], keys[j]) = (keys[j], keys[i]);
    }
}
