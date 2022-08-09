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
