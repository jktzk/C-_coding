public string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0) return "";
    string prefix = strs[0];
    foreach (string s in strs)
    {
        while (!s.StartsWith(prefix))
            prefix = prefix.Substring(0, prefix.Length - 1);
    }
    return prefix;
}
