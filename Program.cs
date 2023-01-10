string[] arr = {"Russia","KFC","Denmark","Man","Georgia","I","The", "Me","End","USA","Kazan","Too",
"Brazil","Wow","Ape","Poland","UFC","England","OK"};

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void PrintArraySorting(string[] sortingArray)
{
    for (int i = 0; i < sortingArray.Length; i++)
    {
        Console.Write(sortingArray[i] + " ");
    }
}

string[] SortingArray(string[] array)
{
    string[] sortingArray = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortingArray[temp] = array[i];
            temp++;
        }
    }
    return sortingArray;
}

Console.WriteLine("Выводим первоначальный массив: ");
PrintArray(arr);
Console.WriteLine("Выводим отсортированный массив с длиной не более 3 символов в элементе: ");
string[] sortingArray = SortingArray(arr);
PrintArraySorting(sortingArray);