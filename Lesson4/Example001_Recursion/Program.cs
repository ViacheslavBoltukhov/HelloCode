// Объявление матрицы из строк
/*
string[,] table = new string[2, 5];


table[1, 2] = "speek";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}
*/

//  Объявление матрицы из чисел
/*
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
*/

//Объявление и заполнени матрицы из чисел с помощью генератора случайных чисел
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
*/

// Раскраска
/*
int[,] pic = new int[20, 20];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,2);
        }
    }
}

void PrintImageArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

void FillImageArray(int row, int col)
{
    if (pic[row,col] == 0)
    {
        pic[row,col] = 1;
        FillImageArray(row - 1, col);
        FillImageArray(row, col - 1);
        FillImageArray(row + 1, col);
        FillImageArray(row, col + 1);
    }
}

PrintImageArray(pic);
FillImageArray(5, 5);
PrintImageArray(pic);
*/

// Факториал

/*
double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

// Фибоначи

/*
double Fibonnachi( int n)
{
    if( n == 1 || n == 2)
    {
        return 1;
    }
    else return Fibonnachi(n - 1) + Fibonnachi(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i}F = {Fibonnachi(i)}");
}
*/

