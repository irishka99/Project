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