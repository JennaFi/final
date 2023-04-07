string[] array = new string[4] { "Hello", "2", "world", ":-)" };


string[] GetCutArray(string[] array)
{
    string[] resultArray = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


PrintArray(GetCutArray(array));