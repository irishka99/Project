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