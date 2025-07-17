/*
 * Problem Link : https://codeforces.com/problemset/problem/1915/C
 */

// binary search algorithm to check the perfect root number
bool sqrtRootNum(long n)
{
    long s = 1;
    long e = (long)1e9;
    while(s <= e)
    {
        long mid = s + (e - s) / 2;
        if (mid * mid == n) return true;
        else if (mid * mid > n) e = mid - 1;
        else s = mid + 1;
    }
    return false;
}


int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    long[] num = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

    long sum = num.Sum();
    if(sqrtRootNum(sum)) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}