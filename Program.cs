//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Программа находит большее и меньшее из двух чисел","Введите первое число");
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
// Console.Write( "Максимальное значение - " );
// Console.WriteLine( number1 );
// Console.Write( "Минимальное значение - " );
// Console.WriteLine( number2 );
// }
// else
// {
//     Console.Write("Максимальное значение - ");
//     Console.WriteLine(number2);
//     Console.Write("Минимальное значение - ");
//     Console.WriteLine(number1);
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.WriteLine("Программа находит наибольшее из 3-х чисел. ");
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int maxnumber=number1;
// if (number2>maxnumber)
// {
//     maxnumber=number2;
// }
// if (number3>maxnumber)
// {
//     maxnumber=number3;
// }
// Console.WriteLine("Наибольшее значение - "+ maxnumber);

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// // (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет


// Console.WriteLine("Программа позволяет определить, является ли число четным");
// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine()); 
// if (number%2 == 0)
// {
//  Console.Write("Введенное число - чётное");
// }
// else
// {
//  Console.Write("Введенное число - нечётное");
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.WriteLine("Программа показывает все чётные числа от 1 до введенного вами числа.");
// Console.WriteLine("Введите число больше 1.");
// int number = Convert.ToInt32(Console.ReadLine());
// int i=1; 
// if (number>1)
// {
//   while (i<number/2+1)
//   {
//     Console.WriteLine(i*2);
//     i++;
//   }
// }
// else 
// {
// Console.WriteLine("Вы ввели некорректное значение.");
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int numberLength = 0;
// int number = 0;
// while(numberLength != 3)
//  {
//     Console.Write("Введите трехзначное число : ");
//     number = Convert.ToInt32(Console.ReadLine());
//     int num = number;
//     int i=0;
//     while(num>0)
//      {
//         i++;
//         num=num/10;
//     }
//     numberLength = i;
// }
// int result = (number/10)%10;
// Console.WriteLine($"Вторая цифра числа {number} = {result}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//  Console.Write("Введите число : ");
//  int number = Convert.ToInt32(Console.ReadLine());
//  int temp = 1;
//  int num = number;
//  int numberLength = 1;
//  int i=0;
//  while(num>0)
//      {
//         i++;
//         num=num/10;
//     }
//     numberLength = i;
// if (number<100)
//  {
//       Console.Write("Третьей цифры нет. ");
//  }
//  else  
//  {
//     i = 0;
//     while (i != numberLength-2)
//      {
//        i++;
//        temp = temp*10;
//      }
//      int result = (number % temp)/(temp/10);
//      Console.WriteLine("Третья цифра числа = " + result);

//  }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int number = -1;

// string [] DayOfWeek = {"Понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

// while (number > 7 || number <1)
// {
//  Console.Write("Введите цифру от 1 до 7 -  "); 
//   number = Convert.ToInt32(Console.ReadLine()); 

// }
// if (number >5)
// {
// Console.Write($"{DayOfWeek [number-1]} - выходной");
// }
// else 
// {
// Console.Write(DayOfWeek[number-1]);
// }


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// string number = "0";
// int length = 0;
// while (length != 5)
// {
//     Console.Write("Введите пятизначное число: ");
//     int input = Convert.ToInt32(Console.ReadLine());
//     number = Convert.ToString(input);
//     length = number.Length;
// }
// string rNumber = String.Join("", number[4], number[3], number[2], number[1], number[0]);

// if (rNumber == number)
// {
//     Console.WriteLine("Число является палиндромом. ");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом. ");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату х1: "); 
// int x1 = Convert.ToInt32(Console.ReadLine());  
// Console.Write("Введите координату y1: "); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату z1: "); 
// int z1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату х2: "); 
// int x2 = Convert.ToInt32(Console.ReadLine());  
// Console.Write("Введите координату y2: "); 
// int y2 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату z2: "); 
// int z2 = Convert.ToInt32(Console.ReadLine()); 

// double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z2-z1,2)); 

// Console.WriteLine($"Расстояние между точкми: {Math.Round(result,2)}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число:  ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// int[] array = new int[n];

// for (int i = 0; i < n ; i++)
// {
//     array [i] = Convert.ToInt32(Math.Pow(i+1,3));
// }
// Console.WriteLine($"Результат: [ {String.Join(", " ,array )} ]");


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int a = 1;
// int b = 0;
// Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
// while (a==1)
// {
//     Console.WriteLine("Введите первое число- ");
//     int number1 = Convert.ToInt32(Console.ReadLine()); 
//     Console.WriteLine("Введите второе число- ");
//     int number2 = Convert.ToInt32(Console.ReadLine()); 
//     int result = Convert.ToInt32(Math.Pow(number1,number2));
//     Console.WriteLine($"Результат: {result} ");
//     Console.WriteLine($"Введите \" 1 \", если хотите продолжить.  ");
//     b=Convert.ToInt32(Console.ReadLine());

//     if (b!=1)
//     {
//      a=0;
//     }

// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN){

//     int count = Convert.ToString(numberN).Length;
//     int temp = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//       temp = numberN - numberN % 10;
//       result = result + (numberN - temp);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine($"Введите {i+1}-й элемент массива: ");
//     array[i]=Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Результат: [ {String.Join(", " ,array )} ]");


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int EvenCounter (int[]array)
// {
//     int result=0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2==0)
//     {
//   result++;
//     }

// }
// return result;
// }
//     int []start= new int[10];
//     for (int i = 0; i < start.Length; i++)
//     {
// start[i]=new Random().Next(100,999);
//     }
// System.Console.WriteLine($"[ {String.Join(" ,", start)} ]");
// System.Console.WriteLine(EvenCounter(start));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[]array= new int [10];

//     for (int i = 0; i < array.Length; i++)
//     {
// array[i]=new Random().Next(1,100);
//     }

//  System.Console.WriteLine($"[ {String.Join(" ,", array)} ]");
//  int result= 0;
//  for (int i=1; i<array.Length;i +=2)
//  {
// result+= array[i];
//  }
// System.Console.WriteLine(result);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Random rand = new Random();
// double[] array = new double[10];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(rand.NextDouble() * 100, 1);
// }
// double max = array[0];
// double min = array[0];
// Console.WriteLine($"[ {String.Join("; ", array)} ]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }

// double result= max-min;
// System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(result,1)}");


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int size =Convert.ToInt32(Console.ReadLine()); 
// int []array =new int [size];
// int i = 0;
// int result = 0;
// for ( i = 0; i < size; i++)
// {
//     Console.WriteLine($"\n Введите значение числа {i+1}");
//     array[i]= Convert.ToInt32(Console.ReadLine()); 
//     if (array[i] >0)
//     {
//         result ++;
//     }
// }
// Console.WriteLine($"\n Кол-во чисел больше 0:\n {result}");


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Console.WriteLine("Введите число, которое хотели бы перевести в двоичную систему счисления");
// int decimalNumber = Convert.ToInt32(Console.ReadLine());
// int temp = decimalNumber;
// int temp1 = 0;
// int result = 0;
// int i = 0;
// while (temp > 0)
// {
//     temp1 = temp % 2;
//     temp = temp / 2;
//     result = result + temp1 * Convert.ToInt32(Math.Pow(10, i));
//     i++;
// }
// Console.WriteLine($"В двоичной системе счисления это будет: {result}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Программа находит точку пересечения двух прямых, заданных уравнениями: \n y = k1 * x + b1, \n y = k2 * x + b2");
// Console.WriteLine("Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// double x = (Convert.ToDouble(b2) - Convert.ToDouble(b1)) / (Convert.ToDouble(k1) - Convert.ToDouble(k2));
// double y = k1 * x + b1;
// Console.WriteLine($"Точка пересечения двух прямых : {Math.Round(x,2)},{Math.Round(y,2)}");

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] GetArray(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round((new Random().NextDouble() * 10 * new Random().Next(-1, 2)), 1);
//         }
//     }
//     return matrix;
// }
// double[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите строку искомого элемента: ");
// int searchIndexi = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец искомого элемента: ");
// int searchIndexj = Convert.ToInt32(Console.ReadLine());
// if (searchIndexi < 0 || searchIndexi > rows - 1 || searchIndexj < 0 || searchIndexj > columns - 1)
// {
//     Console.WriteLine("Такого элемента нет.");
// }
// else
// {
//     Console.WriteLine($"Искомый элемент: {resultMatrix[searchIndexi, searchIndexj]}");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[] sum = new int[columns];
// double[] avg = new double[columns];

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }

//     return matrix;
// }

// int[,] resultMatrix = GetArray(rows, columns);
// PrintArrayAndGetSum(resultMatrix);
// void PrintArrayAndGetSum(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// for (int j = 0; j < resultMatrix.GetLength(1); j++)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         sum[j] += resultMatrix[i, j];
//     }
// }
// for (int i = 0; i < columns; i++)
// {
//     avg[i] = Math.Round(Convert.ToDouble(sum[i]) / Convert.ToDouble(rows), 1);
// }
// Console.Write($"Среднее арифметическое в каждом столбце:\n[ {String.Join("; ", avg)} ]");



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] RandomArray(int n, int m)
// {
//     int[,] matr = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matr[i, j] = new Random().Next(10);
//             Console.Write(matr[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return matr;
// }

// void PrintArray(int[,] inpMatrix)
// {
//     for (int i = 0; i < inpMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inpMatrix.GetLength(1); j++)
//         {
//             Console.Write(inpMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SortedMatrix(int[,] inputMatrix)
// {
//     int n = inputMatrix.GetLength(0);
//     int m = inputMatrix.GetLength(1);
//     int[,] resultMatrix = inputMatrix;
//     int k;
//     int l;
//     int temp;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             for (k = 0; k < m - 1; k++)
//             {
//                 for (l = 0; l < m - 1; l++)
//                 {
//                     if (resultMatrix[i, l + 1] > resultMatrix[i, l])
//                     {
//                         temp = resultMatrix[i, l];
//                         resultMatrix[i, l] = resultMatrix[i, l + 1];
//                         resultMatrix[i, l + 1] = temp;
//                     }
//                 }
//             }
//         }
//     }
//     return resultMatrix;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("\nГенерируем матрицу:");
// int[,] matrix = RandomArray(rows, columns);
// System.Console.WriteLine("\nСортируем строки матрицы:");
// int[,] sortedMatrix = SortedMatrix(matrix);
// PrintArray(sortedMatrix);




// Задача 56: Задайте квадратный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] RandomArray(int n, int m)
// {
//     int[,] matr = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matr[i, j] = new Random().Next(10);
//             Console.Write(matr[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return matr;
// }

// int[] RowSum(int[,] inputMatrix)
// {
//     int n = inputMatrix.GetLength(0);
//     int m = inputMatrix.GetLength(1);
//     int[] resultArray = new int[m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             resultArray[i] += inputMatrix[i, j];
//         }
//     }
//     return resultArray;
// }

// int IndexMin(int[] inpArray)
// {
//     int minIndex = 0;
//     int min = 999;
//     int n = inpArray.Length;
//     for (int i = 0; i < n; i++)
//     {
//         if (inpArray[i] < min)
//         {
//             min = inpArray[i];
//             minIndex = i;
//         }
//     }
//     return minIndex;
// }


// Console.Write("Введите размер квадратного массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = rows;
// int[,] squareMatrix = RandomArray(rows, columns);
// int[] sumArray = RowSum(squareMatrix);
// Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {IndexMin(sumArray)}");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Вспомним школьную программу
// Произведением матрицы A[m*n] на матрицу B[n*k] называется матрица C[m*k]
// такая, что элемент матрицы C, стоящий в i-ой строке и j-ом столбце,
// т.е. элемент C[i,j], равен сумме произведений элементов i-ой строки матрицы A
// на соответствующие элементы j-ого столбца матрицы B.

// int[,] RandomArray(int n, int m)
// {
//     int[,] matr = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matr[i, j] = new Random().Next(10);
//             Console.Write(matr[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return matr;
// }

// int[,] ProductMatrix(int[,] inputMatrix1, int[,] inputMatrix2)
// {
//     int n1 = inputMatrix1.GetLength(0);
//     int m1 = inputMatrix1.GetLength(1);
//     int n2 = inputMatrix2.GetLength(0);
//     int m2 = inputMatrix2.GetLength(1);
//     int[,] outputMatrix = new int[n1, m2];

//     for (int i = 0; i < n1; i++)
//     {
//         for (int j = 0; j < m2; j++)
//         {
//             for (int k = 0; k < m2; k++)
//             {
//                 outputMatrix[i, j] = outputMatrix[i, j] + inputMatrix1[i, k] * inputMatrix2[k, j];
//             }
//             Console.Write(outputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return outputMatrix;
// }

// Console.Write("Введите размер матриц: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// int columns1 = rows1;
// int rows2 = rows1;
// int columns2 = rows1;

// Console.WriteLine("\nГенерируем первую матрицу:");
// int[,] matrix1 = RandomArray(rows1, columns1);

// Console.WriteLine("\nГенерируем вторую матрицу:");
// int[,] matrix2 = RandomArray(rows2, columns2);
// Console.WriteLine("\nСчитаем произведение матриц:");
// int[,] res = ProductMatrix(matrix1, matrix2);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[] numbersList = new int[100 - 10];
// numbersList[0] = 10;
// for (int i = 1; i < 100 - 10; i++)
// {
//     numbersList[i] = numbersList[i - 1] + 1;
// }

// int UniqueNumber(int[] donor)
// {
//     int donorSize = donor.Length;
//     int randomindex = new Random().Next(donorSize - 1);
//     int output = numbersList[randomindex];
//     numbersList[randomindex] = numbersList[donorSize - 1];
//     Array.Resize(ref numbersList, donorSize - 1);
//     return output;
// }
// int[,,] resultMatrix = new int[2, 2, 2];

// Console.Write("Нажмите enter, чтобы сгенерировать трехмерный массив с неповторяющимися двузначными числами:");
// Console.Read();
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         for (int k = 0; k < 2; k++)
//         {
//             resultMatrix[i, j, k] = UniqueNumber(numbersList);
//             Console.WriteLine($"{resultMatrix[i, j, k]} ({i},{j},{k})");
//         }
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// void PrintArray(int[,] inpMatrix)
// {
//     for (int i = 0; i < inpMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inpMatrix.GetLength(1); j++)
//         {
//             Console.Write(inpMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите размер массива:");

// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("\nГенерируем спиральную матрицу:");
// int count = 0;
// int[,] Array = new int[size, size];
// int k = 0;
// int i = k;
// int j = k;
// int n = size - 1;

// while (k < size / 2 + 1)
// {

//     while (j < n)
//     {
//         count++;
//         j++;
//         Array[i, j] = count;
//     }
//     while (i < n)
//     {
//         count++;
//         i++;
//         Array[i, j] = count;
//     }
//     k++;
//     while (j >= k)
//     {
//         count++;
//         j--;
//         Array[i, j] = count;
//     }
//     k++;
//     while (i >= k)
//     {
//         count++;
//         i--;
//         Array[i, j] = count;
//     }
//     n--;
//     k--;

// }

// PrintArray(Array);

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.WriteLine("Введите первое значение (M)");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее значение (N)");
// int n = Convert.ToInt32(Console.ReadLine());

// int List(int start, int finish)
// {
//     int result = start;
//     Console.Write($"{result}\t");
//     if (result < finish)
//     {
//         start++;
//         return List(start, finish);
//     }
//     return result;
// }
// System.Console.WriteLine("\nГенерируем натуральные числа от M до N:");
// List(m, n);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите первое значение (M)");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее значение (N)");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// int Sum(int start, int finish)
// {
//     result = start + result;
//     Console.Write($"{result}\t");
//     if (start < finish)
//     {
//         start++;
//         return Sum(start, finish);
//     }
//     Console.WriteLine($"\nОтвет:{result}");
//     return result;
// }

// Console.WriteLine("\nГенерируем сумму натуральных чисел от M до N:");
// Sum(m, n);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

// Console.WriteLine("Введите первое неотрицательное число (M)");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе неотрицательное число (N)");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int Ackerman(int m,int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return Ackerman(m - 1, 1);
//     }
//     if (m > 0 && n > 0)
//     {
//         return Ackerman(m - 1, Ackerman(m, n - 1));
//     }
//     return 0;
// }
// Console.WriteLine("Вычисляем результат по формуле Аккермана : ");
// Console.WriteLine(Ackerman(firstNumber, secondNumber));