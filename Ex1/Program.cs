void sign()
    {
        Console.WriteLine();
        Console.WriteLine("GeekBrains - лучшая школа в интернете. (;-_-)/");
    }
Console.Clear();
Console.Write("Введите элементы массива разделяя их пробелом: ");
string[] array = Console.ReadLine().Split(" ").Select(x => Convert.ToString(x)).ToArray();
int j = 0;
int s = 0;
for (int i = 0; i < array.Length; i++)
{
    string z = array[i];
    if (z.Length < 4)
        {
            j++; 
        } 
}

string[] array2 = new string[j];

for (int i = 0; i < array.Length; i++)
{
    string z = array[i];
    if (z.Length < 4)
        {
            array2[s] = array[i];
            s++; 
        } 
}
Console.WriteLine();
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine($"Результат: [{string.Join(", ", array2)}]");
sign();