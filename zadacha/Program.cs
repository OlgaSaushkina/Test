Console.Clear();
Console.WriteLine("Задан массив строк: ");
string[] Array = new string[5] { "слон", "dog", "12", ";)", "1234" };
Console.WriteLine(string.Join(", ", Array));
int j = 0;
string[] Array2 = new string[Array.Length];
Console.WriteLine();
Console.WriteLine("Сформирован массив из строк, из имеющегося массива, длина которых меньше либо равна 3 символа: ");
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        Array2[j] = Array[i];
        Console.Write(Array2[j] + " ,");
        j++;
    }

}
Console.WriteLine();