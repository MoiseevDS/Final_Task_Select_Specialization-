// Task SelectSpec

void InputArray(string?[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}

void SecondArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
string[] array2 = new string[array.Length];
InputArray(array);
Console.WriteLine("Начальный массив: ");
PrintArray(array);
SecondArray(array, array2);
Console.WriteLine();
Console.WriteLine("Конечный массив (с длинной не более 3х символов): ");
PrintArray(array2);