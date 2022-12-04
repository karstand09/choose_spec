/*Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

Console.Clear();

string[] array_1 = new string[5] {"12345", "1234", "123", "12", "qwe"};
string[] array_2 = new string[array_1.Length];

void FindThreeChars(string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
    if(array_1[i].Length <= 3)
        {
        array_2[count] = array_1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FindThreeChars(array_1, array_2);
PrintArray(array_2);