// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3 символа.
// Первоначальный массив надо ввести с клавиатуры, либо задать на старте выполнения алгоритма.

System.Console.Write("Введите количество строк в исходном массиве:  ");
int size = int.Parse(Console.ReadLine());
string[] InputArray = new string[size];
string[] TempArray = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.Write($"Введите {i} элемент массива:  ");
    InputArray[i] = Console.ReadLine();
    int lenght = InputArray[i].Length;
    if (lenght < 4)
        TempArray[i] = InputArray[i];
}
var OutputArray = TempArray.Where(x => !string.IsNullOrWhiteSpace(x));
Console.Clear();
Console.WriteLine("Исходный массив [ " + string.Join(", ", InputArray) + " ]");
Console.WriteLine("Полученный массив [ " + string.Join(", ", OutputArray) + " ]");