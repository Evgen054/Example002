Console.Clear();

Console.WriteLine("Введите ваше имя!");

string username = Console.ReadLine();


if (username.ToLower() == "евгений")
{
    Console.WriteLine("Привет, Евгений! Это же ты)))");
}

else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}


