/*
 * Problem Link : https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/R
 */

int ageInDays = int.Parse(Console.ReadLine()!);

int year = ageInDays / 365;
ageInDays = ageInDays % 365;

int months = ageInDays / 30;
ageInDays = ageInDays % 30;

Console.WriteLine($"{year} years");
Console.WriteLine($"{months} months");
Console.WriteLine($"{ageInDays} days");