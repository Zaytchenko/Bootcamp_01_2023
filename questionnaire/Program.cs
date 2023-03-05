// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3 символа.
// Первоначальный массив надо ввести с клавиатуры, либо задать на старте выполнения алгоритма.



System.Console.Write("Введите количество строк в исходном массиве:  ");
int size = int.Parse(Console.ReadLine());
// ввод строк
string[] InputArray = new string[size];
string[] OutputArray = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.Write($"Введите {i} элемент массива:  ");
    InputArray[i] = Console.ReadLine();
    int lenght = InputArray[i].Length;
     if (lenght < 4) 
     OutputArray[i] = InputArray [i];
}
var array = OutputArray.Where(x => !string.IsNullOrWhiteSpace(x));

Console.Clear();
Console.WriteLine("Исходный массив [ " + string.Join(", ", InputArray)+" ]");
Console.WriteLine("Полученный массив [ " + string.Join(", ", array)+" ]");


