/*
 * Problem Link : https://codeforces.com/problemset/problem/1875/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int[] tools = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int time = num[1];
    long sec = (time - 1);
    time = 1;

    int i = 0;
    while( i < num[2])
    {
        time = int.Min(time + tools[i++], num[0]);
        sec += (time - 1);
        time = 1;
    }
    Console.WriteLine(sec+1);
}