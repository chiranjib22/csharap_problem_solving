/*
 * Problem Link : https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Y
 */

long[] numbers = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

long ans = 1;

ans = (1 * (numbers[0] % 100)) % 100;
ans = (ans * (numbers[1] % 100)) % 100;
ans = (ans * (numbers[2] % 100)) % 100;
ans = (ans * (numbers[3] % 100)) % 100;

if (ans < 10) Console.WriteLine($"0{ans}");
else Console.WriteLine(ans);
