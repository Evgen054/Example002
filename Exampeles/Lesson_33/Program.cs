﻿//Задать массив из 12 элементов от 1 до 9 и найти сумму всех положительных и отрицательных элементоов элементов

/* int[] array = new int[12];
for (int i = 0; i < 12; i++)
{
    array[i]= new Random().Next(1,10); 
    Console.WriteLine(array[i]);
    
}
 */


 //КОД АНТОНА

 //Создание массива
 
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

// Вывод массива
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Сумма положительных элементов  массива
int SumPlusArray (int [] array)
{
    int SumPlus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) SumPlus = SumPlus + array[i];
    }
    return SumPlus;
}

// Сумма отрицательных элементов  массива
int SumMinusArray (int [] array)
{
    int SumMinus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) SumMinus = SumMinus + array[i];
    }
    return SumMinus;
}

int [] array = new int [12];
CreatArray (array);
PrintArray (array);
int A = SumPlusArray (array);
int B = SumMinusArray (array);
Console.WriteLine($"Сумма положительных элементов массива равна {A}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {B}");
