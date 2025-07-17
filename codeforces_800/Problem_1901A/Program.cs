/*
 * problem link : https://codeforces.com/problemset/problem/1901/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input
    string[] input = Console.ReadLine()!.Split(' ');
    int n = int.Parse(input[0]);
    int x = int.Parse(input[1]);

    string[] numbers = Console.ReadLine()!.Split(' ');
    int[] a = Array.ConvertAll(numbers, int.Parse);

    // logic
    int ans = a[0];
    for(int i = 1; i<n; i++)
    {
       ans = Math.Max(ans, a[i] - a[i-1]);
    }
    ans = Math.Max(ans, 2 * ( x - a[n - 1]));

    // output
    Console.WriteLine(ans);
}