public int[] MergeSortedArrays(int[] a, int[] b)
{
    return a.Concat(b).OrderBy(x => x).ToArray();
}
