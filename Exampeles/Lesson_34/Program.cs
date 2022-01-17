// Написать программу замены элементов массива на противоположные


//Создать массив

int[] array = new int[12];
void CreatArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        
        Console.Write($"{array[i]},");
        

       /*  array[i] = -array[i];
        Console.Write($"{array[i]}"); 
        Console.WriteLine(); */
    }
    
}

Console.WriteLine("Первоначальное значение равно");
CreatArray(array);




