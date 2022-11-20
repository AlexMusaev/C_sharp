Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет любимая :-*");
}
else
{
    Console.WriteLine("Привет, " + username);
}
