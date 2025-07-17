/*
 * problem link - https://codeforces.com/problemset/problem/158/B
 */

int n = int.Parse(Console.ReadLine()!);
int[] groups = new int[n];

string[] line = Console.ReadLine()!.Split(' ');
for(int i = 0; i<n; i++)
{
    groups[i] = int.Parse(line[i]);
}

solution(groups, n);

void solution(int[] groups, int n)
{
    int answer = 0;
    int three = 0;         
    int two = 0;          
    int one = 0;           

    // count the number of groups containing 3, 2 or 1 member
    for(int i = 0; i < n; i++)
    {
        if (groups[i] == 4) answer++;       // answer count for a group of 4
        else if (groups[i] == 3) three++;
        else if (groups[i] == 2) two++;
        else one++;
    }
    
    // count answer for group of 3
    for (int i = 0; i<three; i++)
    {
        // check if there are a group of 1
        if(one > 0)
        {
            one--;
        }
        answer++;
    }
    
    // count answer for group of 2
    if (two >= 2)
    {
        answer += (two / 2);
        two = (two % 2);
    }

    // check if there are a single group of 2
    if(two == 1)
    {
        // check if there are sufficient single member to make 4
        if(one >= 2)
        {
            one -= 2;
        }
        else
        {
            if (one == 1) one--;
        }
        two--;
        answer++;
    }

    // remaining single groups
    if (one >= 4)
    {
        answer += (one / 4);
        one = (one % 4);
    }
    if (one > 0 && one < 4) answer++;

    Console.WriteLine(answer);
}
