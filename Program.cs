// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int[,] GetMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// void ChangeMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1)-1; k++)
//             {
//                 if (matrix[i,k]<matrix[i,k+1])
//                 {
//                     int temp = matrix[i,k+1];
//                     matrix[i,k+1] = matrix[i,k];
//                     matrix[i,k]=temp;
//                 }
//             }
//         }
//     }
// }

// PrintMatrix(GetMatrix());
// Console.WriteLine("_______________________________");
// ChangeMatrix(matrix);
// PrintMatrix(matrix);

// _________________________________________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] array = new int[4, 4];
// int count = 0;
// int i = 0;
// int j = 0;

// for (j = 0; j < array.GetLength(1); j++)
// {
//     array[i, j] = 1 + count;
//     count++;
// }
// j = 3;
// for (i = 0; i < array.GetLength(0); i++)
// {
//     array[i, j] = 1 + count;
//     count++;
// }
// i = 3;
// for (j = 2; j >= 0; j -= 1)
// {
//     array[i, j] = 1 + count;
//     count++;
// }
// j = 0;
// for (i = 2; i >= 1; i-=1)
// {
//     array[i, j] = 1 + count;
//     count++;
// }
// i = 1;
// for (j = 1; j <= 2; j ++)
// {
//     array[i, j] = 1 + count;
//     count++;
// }
// i = 2;
// for (j = 2; j >= 1; j -=1)
// {
//     array[i, j] = 1 + count;
//     count++;
// }
// for (i = 0; i < array.GetLength(1); i++)
// {
//     for (j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("   ");

// ___________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] array1 = new int[2, 2];

// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             array1[i, j] = new Random().Next(0, 10);
//             Console.Write(array1[i, j] + "   ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("_____________________________");

// int[,] array2 = new int[2, 2];

// {
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             array2[i, j] = new Random().Next(0, 10);
//             Console.Write(array2[i, j] + "   ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("_____________________________");

// int[,] array3 = new int[2, 2];

// {
//     for (int i = 0; i < array3.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 sum += array1[i, k] * array2[k, j];
//             }
//             Console.Write((array3[i, j] = sum) + "   ");
//         }
//         Console.WriteLine();
//     }

// }

// ________________________________________________________________________________________

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int [,,] array3D = new int [2,2,2];
// GetIndex(array3D);
// PrintIndex(array3D);

// void GetIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k})");
//             }
//         }
//     }
// }
// void PrintIndex(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// ______________________________________________________________________________________

