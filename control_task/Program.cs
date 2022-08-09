// Контрольная работа Соболев В.А.
void PrintArray (string[] array)

{
    Console.Write ("Результат: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.Write ("]");
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}