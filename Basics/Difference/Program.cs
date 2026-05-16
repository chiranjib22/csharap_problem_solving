/*
 * Problem Link : https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/D
 */

int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Console.WriteLine($"Difference = {(numbers[0] * numbers[1]) - (numbers[2] * numbers[3])}");