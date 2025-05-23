public int FindMax(int[] nums)
{
    int max = nums[0];
    foreach (int n in nums)
        if (n > max) max = n;
    return max;
}
