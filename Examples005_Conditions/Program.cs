Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower == "петя")
{
    Console.WriteLine("Ура, это же Петя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}