public class Solution 
{
    public static void Main(String[] args)
    {
        int[] number = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        List<int> prefix = new List<int>();
        prefix.Add(0);

        for(int i = 1; i <= number[0]; i++)
        {
             prefix.Add(prefix[i - 1] + input[i - 1]);
        }

        int query = int.Parse(Console.ReadLine()!);

        for(int i = 0; i<query; i++)
        {
            int[] range = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int ans = prefix[range[1]+1] - prefix[range[0]];
            Console.WriteLine(ans);
        }
    } 

}