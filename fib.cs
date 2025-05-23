private Dictionary<int, int> memo = new Dictionary<int, int>();
public int Fib(int n)
{
    if (n <= 1) return n;
    if (memo.ContainsKey(n)) return memo[n];
    memo[n] = Fib(n - 1) + Fib(n - 2);
    return memo[n];
}
