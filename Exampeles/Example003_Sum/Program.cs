int numberA = new Random().Next(1,10); // Случайное число от 1 до 9
Console.Write("Число А = ");
Console.WriteLine(numberA);

int numberB = new Random().Next(1,10);
Console.Write("Число В = ");
Console.WriteLine(numberB);

Console.Write("Результат сложения двух чисел = ");
int result = numberA + numberB;

Console.WriteLine(result);