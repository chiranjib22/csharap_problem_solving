/*
 * problem link : https://codeforces.com/problemset/problem/1890/A
 */

int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] a = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

    Dictionary<int, int> freq = new Dictionary<int, int>();
    for (int i = 0; i < n; i++)
    {
        if(freq.ContainsKey(a[i]))
            freq[a[i]]++;
        else
            freq[a[i]] = 1;
    }
    if (freq.Count >= 3)
        Console.WriteLine("NO");
    else if(freq.Count == 2)
    {
        int number1count = freq[freq.Keys.ElementAt(0)];
        int number2count = freq[freq.Keys.ElementAt(1)];

        if(n%2 == 0 && number1count == number2count)
            Console.WriteLine("YES");
        else if (n % 2 == 1 && Math.Abs(number2count - number1count) == 1)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
    else
        Console.WriteLine("YES");
}
