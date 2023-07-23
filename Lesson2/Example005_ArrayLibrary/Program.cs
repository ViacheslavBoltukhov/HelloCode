void FillArray(int[] collettion)
{
    int lenght = collettion.Length;
    int index = 0;
    while (index < lenght)
    {
        collettion[index] = new Random().Next(1,10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while (possition < count)
    {
        Console.WriteLine(col[possition]);
        possition++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
                position = index;
                break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
array[4] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 44);
Console.WriteLine(pos);