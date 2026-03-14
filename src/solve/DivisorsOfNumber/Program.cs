int number = int.Parse(Console.ReadLine()!);

# region brute Force Approach
//  Time complexity : O(n), Space Complexity : O(n)

List<int> Divisor = new List<int>();
for(int i = 1; i * i <= number; i++)
{
    if(number % i == 0)
    {
        Divisor.Add(i);
        if (i != number / i) Divisor.Add(number / i);
    }
}
Divisor.Sort();
foreach(int d in Divisor)
{
    Console.Write(d + " ");
}
# endregion

# region optimal Approach
// Time Complexity : O(sqrt(n) log n), Space Complexity : O(sqrt(n))
SortedSet<int> divisors = new SortedSet<int>();

for(int i = 1; i<= (int)Math.Sqrt(number); i++)
{
    if(number % i == 0)
    {
        divisors.Add(i);
        if (i != number / i) divisors.Add(number / i);
    }
}

foreach(int divisor in divisors)
{
    Console.Write(divisor + " ");
}
#endregion
