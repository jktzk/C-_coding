public int FirstUniqChar(string s)
{
    var count = new Dictionary<char, int>();
    foreach (char c in s)
        count[c] = count.GetValueOrDefault(c, 0) + 1;
    for (int i = 0; i < s.Length; i++)
        if (count[s[i]] == 1) return i;
    return -1;
}
