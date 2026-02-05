#region optimal approach
// Time Complexity : O(log(number), Space Complexity : O(1)

int number = int.Parse(Console.ReadLine()!);

// reverse a number
int temp = number;
int reversedNumber = 0;
while(temp != 0)
{
    reversedNumber = reversedNumber * 10 + temp % 10;
    temp /= 10;
}
if(reversedNumber == number)
    Console.WriteLine("Palindrome");
else
    Console.WriteLine("Not Palindrome"); 
#endregion