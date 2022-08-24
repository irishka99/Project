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

