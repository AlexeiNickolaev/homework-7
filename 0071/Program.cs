// Показать двумерный массив размером m×n заполненный вещественными числами
void FillMatrix(double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.NextDouble() * 100;
    }
}
void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}; ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}
// Задать двумерный массив следующим правилом: Amn = m+n
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void ChangeElementMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}
// В матрице чисел найти сумму элементов главной диагонали
int SumElementMatrix(int[,] matrix)
{
    int sum = default;
    int length = 0;
    if (matrix.GetLength(0) > matrix.GetLength(1)) length = 1;

    for (int i = 0; i < matrix.GetLength(length); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}
// В двумерном массиве показать позиции числа, заданного пользователем 
// или указать, что такого элемента нет
string NumberPosition(int[,] matrix, int number)
{
    string position=string.Empty;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)position= $"Позиция числа ({i}, {j});";
            else if(position==string.Empty) position="Такого числа нет";
        }  
    }
    return position;
}   

Console.WriteLine("Показать двумерный массив размером m x n заполненный вещественными числами");
Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrixD = new double[m, n];
FillMatrix(matrixD);
Console.WriteLine();
PrintMatrixDouble(matrixD);
Console.WriteLine();
Console.ReadKey();
Console.Clear();

Console.WriteLine("Задать двумерный массив следующим правилом: Amn = m+n");
int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
Console.ReadKey();
Console.Clear();

Console.WriteLine("В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
PrintMatrix(matrix);
Console.WriteLine();
ChangeElementMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.ReadKey();
Console.Clear();

Console.WriteLine("В матрице чисел найти сумму элементов главной диагонали");
PrintMatrix(matrix);
SumElementMatrix(matrix);
Console.WriteLine($"Сумма элементов главной диагонали равна {SumElementMatrix(matrix)}");
Console.WriteLine();
Console.ReadKey();
Console.Clear();


Console.WriteLine("В двумерном массиве показать позиции числа, заданного пользователем  или указать, что такого элемента нет");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
PrintMatrix(matrix);
NumberPosition(matrix, number);
Console.WriteLine(NumberPosition(matrix, number));

