Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
     Console.WriteLine("Здарова, босс!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
