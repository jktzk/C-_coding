public bool IsPalindrome(string s)
{
    int left = 0, right = s.Length - 1;
    while (left < right)
    {
        if (s[left++] != s[right--]) return false;
    }
    return true;
}
