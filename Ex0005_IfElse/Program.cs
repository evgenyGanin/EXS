Console.Clear();
// Console.Write("Как тебя зовут:");
// string username = Console.ReadLine();

// if (username == "Маша")
// {
//     Console.WriteLine("О, добро пожаловать, Маша!");
// }
// else
// {
//     Console.Write("Иди нафиг, ");
//     Console.WriteLine(username);
// }

Console.Write("Как тебя зовут:");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("О, добро пожаловать, Маша!");
}
else
{
    Console.Write("Иди ты нафиг, ");
    Console.WriteLine(username);
}
