/*
 * Problem Link : https://codeforces.com/problemset/problem/1791/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t -- > 0)
{
    char c = char.Parse(Console.ReadLine()!);
    string str = "Codeforces";
    if(str.Contains(c)) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}