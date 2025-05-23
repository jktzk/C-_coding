public int CountVowels(string s)
{
    return s.Count(c => "aeiouAEIOU".Contains(c));
}
