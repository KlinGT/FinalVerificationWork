/*
Задача: Напишите программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равно 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
личше обойтись исключительно массивами.
*/
Console.Clear();

// перебор массива:
string[] IteratingThroughArray(string[] original)
{
    string[] result = new string[original.Length];
    int count = 0;

    for (int i = 0; i < original.Length; i++)
    {
        if (original[i].Length <= 3)
        {
            result[count] = original[i];
            count++;
        }
    }
    return result;
}

// вывод массива в консоль:
void OutputArrayToTheConsole(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] original = new string[6] { "старт", "(",  "o-", "привет", "_-o", ")" };
Console.WriteLine("Исходные значения: ");
OutputArrayToTheConsole(original);

string[] result = IteratingThroughArray(original);
Console.WriteLine("\nРезультат: ");
OutputArrayToTheConsole(result);

Console.WriteLine();