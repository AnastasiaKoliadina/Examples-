Console.write ("Введите имя пользователя:  ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.write("Привет, ");
    Console.WriteLine(username);
}