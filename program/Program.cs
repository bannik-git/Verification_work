string GetAnswer (string text)
{
    Console.Write(text);
    return Console.ReadLine() ?? String.Empty;
}

void FillArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = GetAnswer($" Введите элемент массива №{i + 1}: ");
}

void FillResultArray (string[] resultArray, string[] initialArray, int desiredLength)
{
    int i = 0;
    for (int j = 0; j < initialArray.Length; j++)
    {
        if (initialArray[j].Length <= desiredLength)
        {
            resultArray[i] = initialArray[j];
            i++;
        }
    }
}

void PrintArray (string text, string[] array)
{
    Console.WriteLine();
    Console.WriteLine($"{text}[{string.Join(", ", array)}]\n");
}

int size = Convert.ToInt32(GetAnswer("Введите длину массива: "));
int desiredStringLength = 3; //Длина строки по условию должна быть меньше или равна 3 символам
string[] array = new string[size];

Console.Clear();
Console.WriteLine("Заполнение массива:");
FillArray(array);
PrintArray("Ваш массив: ", array);

int sizeResultArray = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= desiredStringLength)
        sizeResultArray++;

string[] resultArray = new string[sizeResultArray];
FillResultArray(resultArray, array, desiredStringLength);
PrintArray("Итоговый массив: ", resultArray);
