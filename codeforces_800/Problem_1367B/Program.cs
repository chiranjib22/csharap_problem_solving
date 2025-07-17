/*
 * Problem Link : https://codeforces.com/problemset/problem/1367/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (i % 2 == 0)
        {
            if (a[i] % 2 != 0) countEven++;
        }
        else
        {
            if (a[i] % 2 == 0) countOdd++;
        }
    }

    if(countEven == countOdd) Console.WriteLine(countEven);
    else Console.WriteLine(-1);
}