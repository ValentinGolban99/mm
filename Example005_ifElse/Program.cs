Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")//ToLower - для решения проблемы большых букв. if - если.
{
    Console.WriteLine("Ура, это же Маша");
}
else//иначе
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}


