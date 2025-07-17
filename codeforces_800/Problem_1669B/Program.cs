/*
 * Problem Link: https://codeforces.com/problemset/problem/1669/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Array.Sort(num);
    int count = 1;
    int found = -1;

    for(int i = 1; i<n; i++)
    {
        if (num[i-1] == num[i])
        {
            count++;
            if(count == 3)
            {
                found = num[i];
                break;
            }
        }else
        {
            count = 1;
        }
    }
    Console.WriteLine(found);

}