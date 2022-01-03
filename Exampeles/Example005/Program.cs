Console.WriteLine ("Введите ваше имя");
string username = Console.ReadLine();

if (username.ToLower() == "евгений") // ToLower - преобразует текст к нижнему регистру
{
     Console.Write ("Ура! Это же, Евгений!!!");
}

else
{
     Console.Write ("Привет, ");
     Console.WriteLine(username); 
}