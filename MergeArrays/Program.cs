namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {

    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int n1 = array1.Length;
        int n2 = array2.Length;
        int[] result = new int[n1 + n2];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < n1 && j < n2)
    {
        if (array1[i] <= array2[j])
        {
            result[k++] = array1[i++];
        }
        else
        {
            result[k++] = array2[j++];
        }
    }

    while (i < n1)
    {
        result[k++] = array1[i++];
    }

    while (j < n2)
    {
        result[k++] = array2[j++];
    }

    return result;
    
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        if (array == null || array.Length <= 1)
        return true;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            return false;
        }
    }

    return true;
    }
}

