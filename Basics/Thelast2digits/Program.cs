/*
 * Problem Link : https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Y
 */

long[] numbers = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

long result = numbers[0] * numbers[1] * numbers[2] * numbers[3];

Console.WriteLine(result);

string digit = Convert.ToString(result % 10);
result = result / 10;
digit = digit + Convert.ToString(10 * (result % 10));

Console.WriteLine(digit);

