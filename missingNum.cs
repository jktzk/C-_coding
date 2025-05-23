public int MissingNumber(int[] nums)
{
    int n = nums.Length;
    int total = n * (n + 1) / 2;
    return total - nums.Sum();
}
