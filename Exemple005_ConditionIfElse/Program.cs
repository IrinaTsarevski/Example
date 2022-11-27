Console.WriteLine("Введите имя пользователя латиницей:  ");
string username = Console.ReadLine();

if(username.ToLower() == "irina")
{
    Console.WriteLine("Привет, Иринка-картинка!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
