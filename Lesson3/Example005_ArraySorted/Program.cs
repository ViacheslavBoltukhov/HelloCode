// Сортировка массива

int[] arr = {1,5,4,3,2,6,7,1,1};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMaxToMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temprory = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temprory;
    }
}

void SelectionSortMinToMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temprory = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprory;
    }
}
PrintArray(arr);
SelectionSortMinToMax(arr);
PrintArray(arr);
SelectionSortMaxToMin(arr);
PrintArray(arr);
