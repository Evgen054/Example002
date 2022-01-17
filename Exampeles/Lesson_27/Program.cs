/* / найти кол-во цифр в числе


 Console.WriteLine("Введите чмсло А");
int A = Convert.ToInt32(Console.ReadLine());

int ost = A/10;

Console.WriteLine(ost);



Console.Clear();
Console.Write("Введите число: ");
int chislo=int.Parse(Console.ReadLine());
int i=0;
while(chislo>0) 
{
   i++;
   chislo/=10;
}
Console.WriteLine("Количество цифр: {0}", i);
return 0;

 */

/* int Numbers (int A)
{
    int count = 0;
    while (A != 0)
    {
        A = A/10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = Numbers (A);
Console.WriteLine($"В числе {A} {N} цифр"); */



/* 


int SumNumbers(int A)
{
    int sum = 0;
    while (A > 0)
    {
        int B = A % 10;
        A = A / 10;
        sum = sum + B;
    }
    return sum;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = SumNumbers(A);
Console.WriteLine($"В числе {A} сумма цифр равна {N}");

 */






int Numbers(int A)
{
    
    int sum = 0;
    while (A != 0)
    {
        int B = A % 10;
        A = A / 10;
        sum = sum + B;
       
    }
    return sum;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = Numbers(A);
Console.WriteLine($"В числе {A} {N} цифр");