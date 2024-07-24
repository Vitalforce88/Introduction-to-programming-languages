// // Задача 1
// // Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//          //Введите сюда свое решение
//       int count = 0;
//       foreach(int e in numbers){
//         if(e >= minRange && e <= maxRange) ++count;
//       }
//       return count;
//     }
    
//     public static void PrintResult(int[] array)
//     {        
//           //Введите сюда свое решение
//       int x = CountItemsRange(array, 10, 90);
//       Console.WriteLine(x);
//     }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

// Задача 2
// using System;
// using System.Linq;

// class UserInputToCompileForTest
// { 
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//       int count = 0;
//       foreach(int e in numbers){
//         if((e % 2) == 0) ++count;
//       }
//       return count;
//     }
    
//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//       int x = CountEvenItems(array);
//       Console.WriteLine(x);
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

// Задача 3
// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.
// using System;
// using System.Linq;

// class UserInputToCompileForTest
// { 
//     // Разница между максимальным и минимальным элементами массива
    
//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//       double min = numbers[0];
//       foreach(double m in numbers)
//       {
//         if(m < min)
//         {
//           min = m;
//         }
//       }
//       return min;
//     }
    
//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//             double max = numbers[0];
//       foreach(double m in numbers)
//       {
//         if(m > max)
//         {
//           max = m;
//         }
//       }
//       return max;
//     }
    
    
    
//     public static void PrintResult(double[] array)
//     {
//       double result = (FindMax(array)) - (FindMin(array));
//       Console.WriteLine(result);
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }
