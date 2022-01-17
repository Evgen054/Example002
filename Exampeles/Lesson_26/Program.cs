// Возвести число А в натуральную степень Б
int f(int A, int B)
{
    int count = 1;
    int degree = 1;
    while (count <= B)
    {
        degree = degree*A;
        count++;
    }
    return degree;
}
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возвести?");
int B = Convert.ToInt32(Console.ReadLine());
int N = f(A, B);
Console.WriteLine(N);

