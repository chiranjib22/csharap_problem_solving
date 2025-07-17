/*
 *  Problem Link: https://codeforces.com/problemset/problem/1903/A
 */

// test case input
int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input
    string[] input = Console.ReadLine()!.Split(' ');
    int n = int.Parse(input[0]);
    int k = int.Parse(input[1]);
    string[] arr = Console.ReadLine()!.Split(' ');
    int[] a = Array.ConvertAll(arr, int.Parse);

    // logic
    int[] b = (int[])a.Clone();
    Array.Sort(b);

    if(b.SequenceEqual(a) || k > 1)
    {
        Console.WriteLine("YES");
    }else
    {
        Console.WriteLine("NO");
    }
}