/*
 * Program Link: https://codeforces.com/problemset/problem/1845/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input

    string[] input = Console.ReadLine()!.Split(' ');
    int n = int.Parse(input[0]);
    int k = int.Parse(input[1]);
    int x = int.Parse(input[2]);

    // logic

    if(x != 1)
    {
        Console.WriteLine("YES");
        Console.WriteLine(n);
        Console.Write(1);
        for(int i = 2; i<=n; i++)
        {
            Console.Write(" " + 1);
        }
        Console.WriteLine();
    }
    else // x == 1
    {
        if(k == 1 || (k == 2 && n%2 != 0))
        {
            Console.WriteLine("NO");
        }
        else
        {
            if(n%2 == 0)
            {
                Console.WriteLine("YES");
                Console.WriteLine(n/2);
                Console.Write(2);
                for (int i = 2; i <= n/2; i++)
                {
                    Console.Write(" " + 2);
                }
                Console.WriteLine();
            } else
            {
                Console.WriteLine("YES");
                Console.WriteLine((n-3)/2 + 1);
                Console.Write(3);
                for (int i = 2; i <= (n - 3) / 2 + 1 ; i++)
                {
                    Console.Write(" " + 2);
                }
                Console.WriteLine();
            }
        }
    }
}