// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

//1.
// void SystemEnter()
// {
//     bool flag = true;
//     System.Console.WriteLine("Введите число...");
//     System.Console.WriteLine("PS: для завершения введите q или число, сумма чисел которого чётна:");
//     while (flag == true)
//     {
//         string enter = Console.ReadLine();
//         if (enter == "q")
//         {
//             flag = false;
//         }

//         int n = Convert.ToInt32(enter);
//         int sum = 0;
//         while (n > 0)
//         {
//             int CurrentDigit = n % 10;
//             n /= 10;
//             sum += CurrentDigit;
//         }
//         if (sum % 2 == 0) flag = false;

//         else flag = false;

//     }
//     System.Console.WriteLine("Программа завершена");

// }

//2.
int EvenCountInArray(int[] array)
{
    int counter = 0;
    foreach(int num in array)
    {
        if(num % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

//3.
int[] ReverseArray(int[] arr)
{
    for(int i = 0; i <= arr.Length-(i+1);++i)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length-(i+1)];
    arr[arr.Length-(i+1)] = temp;
}
return arr;
}
//1.
//SystemEnter();

//2.
int[] MyRandomArray = new int[15];
Random rnd = new Random();
for(int i = 0; i != ((MyRandomArray.Length) - 1); i++)
{
    int ranValue = rnd.Next(100,1000);
    MyRandomArray[i] = ranValue;
    System.Console.Write($"{ranValue}, ");
}
System.Console.WriteLine(" ");
System.Console.WriteLine($"{EvenCountInArray(MyRandomArray)} even numbers");

//3.
int[] arr = new int[10]{1,2,3,4,5,6,7,8,9,10};
foreach (int item in arr)
{
    System.Console.Write(item);
    System.Console.Write(" ");
}
int[] ResultArray = ReverseArray(arr);
System.Console.WriteLine(" ");
foreach (int item in ResultArray)
{
    System.Console.Write(item);
    System.Console.Write(" ");
}