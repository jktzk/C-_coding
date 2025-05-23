public int MajorityElement(int[] nums)
{
    var count = new Dictionary<int, int>();
    foreach (int n in nums)
    {
        if (!count.ContainsKey(n)) count[n] = 0;
        count[n]++;
        if (count[n] > nums.Length / 2) return n;
    }
    return -1;
}
