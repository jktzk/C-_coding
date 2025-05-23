public int FindDuplicate(int[] nums)
{
    var seen = new HashSet<int>();
    foreach (int n in nums)
        if (!seen.Add(n)) return n;
    return -1;
}
