Console.WriteLine("Input username! ");
string username = Console.ReadLine();
if (username.ToUpper() == "MASCHA")
{
    Console.WriteLine("Hello, Mascha, here's your friend!");
}
else
{
    Console.WriteLine($"Hello, {username}!");
}