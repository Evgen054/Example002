Console.Clear();


void method1()
{
    Console.WriteLine("Автор EVG54");
}
method1();

void method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
method2("Текст", 4);


int method3()
{
    return DateTime.Now.Year;
}
int Year = method3();
Console.WriteLine(Year);

/* string method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = method4(9, "z");
Console.WriteLine(res); */

string method4(int count, string text)
{
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = method4(9, "z");
Console.WriteLine(res);




// Простая таблица умножения

/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
} */




// Задача с текстом
/* – Я думаю, – сказал князь, улыбаясь, – что, 
ежели бы вас послали вместо нашего милого Винценгероде, 
вы бы взяли приступом согласие прусского короля.
Вы так красноречивы. Вы дадите мне чаю?  */

/* string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";

    }

    return result;
}
string newtext = Replace(text, ' ', '|');
Console.WriteLine(newtext);
Console.WriteLine();

newtext = Replace(newtext, 'к', 'K');
Console.WriteLine(newtext); */


int[] arr = { 5, 8, 7, 4, 3, 6, 9, 1, 5, 4 };

/* void PrintArray(int[], Array) */

void PrintArray(int[] array)
{

    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]< array [minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array [i] = array [minPosition];
        array [minPosition] = temporary;
    }

}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
SelectionSortMax(arr);

PrintArray(arr);
