int size = 5;
string[] arr1 = new string [size];
Console.WriteLine ($"Введите значения через энтер:");
Fillarray(arr1);
Console.Clear();

void Fillarray (string[] arr)
{
    for (int i =0; i <size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";

    }
}
string[] arr2 = new string[arr1.Length];
void SecondArrayWithIF(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i <= 3; i++)
    {
        Console.Write(arr[i]+" ");
    }
Console.Write("]");
}

SecondArrayWithIF(arr1, arr2);
PrintArray(arr2);