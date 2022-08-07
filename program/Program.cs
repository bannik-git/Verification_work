string GetAnswer (string text)
{
    Console.Write(text);
    return Console.ReadLine() ?? String.Empty;
}

void FillArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" Введите элемент массива №{i + 1}: ");
        array[i] = Console.ReadLine() ?? String.Empty;
    }
}

 



int size = Convert.ToInt32(GetAnswer("Введите длину массива: "));
string[] array = new string[size];

Console.Clear();
Console.WriteLine("Заполнение массива:");
FillArray(array);



