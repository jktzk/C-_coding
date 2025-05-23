public int MaxSubArray(int[] nums)
{
    int maxSum = nums[0], currSum = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        currSum = Math.Max(nums[i], currSum + nums[i]);
        maxSum = Math.Max(maxSum, currSum);
    }
    return maxSum;
}
