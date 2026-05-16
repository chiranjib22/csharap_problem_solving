/*
 * Problem link : https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/C
 */

int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Console.WriteLine($"{numbers[0]} + {numbers[1]} = {numbers[0] + numbers[1]}");
Console.WriteLine($"{numbers[0]} * {numbers[1]} = {numbers[0] * numbers[1]}");
Console.WriteLine($"{numbers[0]} - {numbers[1]} = {numbers[0] - numbers[1]}");