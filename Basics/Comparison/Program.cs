string expression = Console.ReadLine()!;

string[] symbole = expression.Split(" ").ToArray();

if (Convert.ToInt32(symbole[0]) > Convert.ToInt32(symbole[2]))
{
    if (symbole[1] == ">")
    {
        Console.WriteLine("Right");
    }
    else { 
        Console.WriteLine("Wrong");
    }
}
else if(Convert.ToInt32(symbole[0]) < Convert.ToInt32(symbole[2]))
{
    if (symbole[1] == "<")
    {
        Console.WriteLine("Right");
    }
    else
    {
        Console.WriteLine("Wrong");
    }
}
else if (Convert.ToInt32(symbole[0]) == Convert.ToInt32(symbole[2]))
{
    if (symbole[1] == "=")
    {
        Console.WriteLine("Right");
    }
    else
    {
        Console.WriteLine("Wrong");
    }
}