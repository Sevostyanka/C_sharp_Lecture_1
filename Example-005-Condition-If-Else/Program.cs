Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine ("Ура, вот и ты, дорогая Машуня!");
}
else
{
    Console.Write("Приветствую, ");
    Console.Write(username);
}
