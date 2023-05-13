void Proverka(string[] arrayfirst, string[] arraysecond)
{
    int count = 0;
    for (int i = 0; i < arrayfirst.Length; i++)
    {
    if(arrayfirst[i].Length <= 3)
        {
        arraysecond[count] = arrayfirst[i];
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



string[] arrayfirst = new string[5] {"123", "23", "hello", "world", "res"};
string[] arraysecond = new string[arrayfirst.Length];
PrintArray(arrayfirst);
Proverka(arrayfirst, arraysecond);
PrintArray(arraysecond);