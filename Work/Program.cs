void PrintArray(string[] x)
{
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < x.Length; i++)
    {
        Console.Write("{0}\t", x[i]);
    }
    Console.WriteLine();
    
}

void ResultArray(string[] y)
{
    Console.WriteLine("Результат: ");
    string[] newarr = new string[y.Length];
    for (int i = 0; i < y.Length; i++)
    {
        if (y[i].Length <= 3)
        {
            newarr[i] = y[i];
            Console.Write("{0}\t", newarr[i]);
        }
    }
}