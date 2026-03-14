int number = int.Parse(Console.ReadLine()!);

#region Brute Force Approach
// Time Complexity : O(log n), Space Complexity : O(1)
int numberOfDigits = (number > 0) ? (int)Math.Log10(number) + 1 : 1;
int temp = number;

int sum = 0;

while(temp != 0)
{
    int digit = temp % 10;
    sum += (int)Math.Pow(digit, numberOfDigits);
    temp /= 10;
}

if(sum == number) Console.WriteLine("Armstrong Number");
else Console.WriteLine("Not an Armstrong Number");

#endregion
