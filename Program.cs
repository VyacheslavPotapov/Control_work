// Написать программу которая из имеющегося массива строк формирует массив из 
// строк, длина которого меньше или равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

int j = 0;
string[] mas1 = { "5", "look", "565", "k", "people" };
string[] mas2 = new string[mas1.Length];
for (int i = 0; i < mas1.Length; i++)
{
    if (mas1[i].Length <= 3)
    {
        mas2[j] = mas1[i];
        j++;
    }
}
OutputArray(mas1);
Console.WriteLine();
OutputArray(mas2);
static void OutputArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}