void InputArray(string?[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] =Console.ReadLine(); 
}

void exitArray(string?[] array, int n)
{
    for (int i=0; i<array.Length; i++)
        if (array[i].Length<=n)
            Console.WriteLine(array[i]);
}

Console.Clear();
Console.WriteLine("Введите длинну масива ");
int n =  int.Parse(Console.ReadLine());
string?[] array = new string[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Введите длину искамых строк ");
int m =  int.Parse(Console.ReadLine());
exitArray(array,m);