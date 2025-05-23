public bool IsValid(string s)
{
    var stack = new Stack<char>();
    var map = new Dictionary<char, char> { { ')', '(' }, { '}', '{' }, { ']', '[' } };

    foreach (char c in s)
    {
        if (map.ContainsValue(c))
            stack.Push(c);
        else if (map.ContainsKey(c))
        {
            if (stack.Count == 0 || stack.Pop() != map[c])
                return false;
        }
    }
    return stack.Count == 0;
}
