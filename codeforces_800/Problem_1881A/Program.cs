/*
 * Problem Link : https://codeforces.com/problemset/problem/1881/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string[] input = Console.ReadLine()!.Split(' ');
    int n = int.Parse(input[0]);
    int m = int.Parse(input[1]);

    string x = Console.ReadLine()!;
    string s = Console.ReadLine()!;

    //Console.WriteLine(m + " " + n);
    //Console.WriteLine(x);
    //Console.WriteLine(s);

    // logic
    bool isPossible = false;
    int i = 0;
    do
    {
        if(isFound(x,s))
        {
            isPossible = true;
            break;
        }
        x = x + x;
        i++;

    } while (i <= 5);
    
    if(isPossible) Console.WriteLine(i);
    else Console.WriteLine(-1);
}

bool isFound(string x, string s)
{
    if (x.Length < s.Length) return false;
    
    // apply sliding window
    for(int i = 0; i<x.Length - s.Length + 1; i++)
    {
        if (x.Substring(i, s.Length) == s) return true;
    }
    return false;
}