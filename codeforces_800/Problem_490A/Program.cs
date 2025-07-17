/*
 * Problem Link : https://codeforces.com/problemset/problem/490/A
 */

int t = int.Parse(Console.ReadLine()!);

List<int> programmer = new List<int>();
List<int> mathematician = new List<int>();
List<int> sportsman = new List<int>();

int[] nums = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

for(int i = 0; i<t; i++)
{
    if (nums[i] == 1) programmer.Add(i+1);
    else if (nums[i] == 2) mathematician.Add(i+1);
    else sportsman.Add(i+1);
}

int teams = Math.Min(programmer.Count, mathematician.Count);
teams = Math.Min(teams, sportsman.Count);

Console.WriteLine(teams);

if(teams > 0)
{
    for(int i = 0; i<teams; i++)
    {
        Console.WriteLine($"{programmer[i]} {mathematician[i]} {sportsman[i]}");
    }
}