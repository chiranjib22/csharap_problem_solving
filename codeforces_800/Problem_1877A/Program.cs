/*
 * Problem Link : https://codeforces.com/problemset/problem/1877/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int teams = int.Parse(Console.ReadLine()!);
    int[] efficiency = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    // logic
    int totalEfficiency = 0;
    foreach(var ele in efficiency)
    {
        totalEfficiency += ele;
    }
    Console.WriteLine(0-totalEfficiency);
}