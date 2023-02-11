Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("ура это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}