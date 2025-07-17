/*
 * Problem Link : https://codeforces.com/problemset/problem/1837/A
 */

using System.Xml;

List<int> GetDistances(int x, int k)
{
    List<int> list = new List<int>();

    int i = x;
    while(x > 0)
    {
        if (i <= x && i % k != 0)
        {
            list.Add(i);
            x -= i;
            continue;
        }
        i--;
    }
    return list;
}


int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input
    string[] input = Console.ReadLine()!.Split(' ');
    int x = int.Parse(input[0]);
    int k = int.Parse(input[1]);

    // logic
    List<int> list = GetDistances(x, k);
    Console.WriteLine(list.Count);

    // output
    Console.Write(list[0]);
    for (int i = 1; i < list.Count; i++)
    {
        Console.Write($" {list[i]}");
    }
    Console.WriteLine();
}