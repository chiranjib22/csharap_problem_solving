/*
 * Problem Link : https://codeforces.com/problemset/problem/1380/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] permutations = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    bool founded = false;
    for(int i = 0, j = i+1 ;i<n-2 && j<n-1; i++,j++)
    {
        if (permutations[i] < permutations[j])
        {
            for (int k = j + 1; k < n; k++)
            {
                if (permutations[j] > permutations[k])
                {
                    Console.WriteLine("YES");
                    Console.WriteLine($"{i+1} {j+1} {k+1}");
                    founded = true;
                    break;
                }
            }
        }if (founded) break;
    }
    if(!founded)Console.WriteLine("NO");
}