﻿// Показать двумерный массив размером m×n заполненный вещественными числами
void FillMatrix(double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = rnd.NextDouble() * 100;
    }
}    
void PrintMatrix(double[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j<matrix.GetLength(1)-1)Console.Write($"{matrix[i, j]}; ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

       
Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");


double[,] matrixD = new double[m, n];
FillMatrix(matrixD);
Console.WriteLine();
PrintMatrix(matrixD);