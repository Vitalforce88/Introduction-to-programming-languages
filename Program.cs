// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

//1.

void NumbersOnSegment(int m, int n, bool flag = true)
{
    
    if(m == n)
    {
        System.Console.Write($"{m} ]");
        return;
    }
    if(flag == true) System.Console.Write("[ ");
    System.Console.Write($"{m}, ");
    NumbersOnSegment(m+1,n,false);
}

NumbersOnSegment(5,20);
System.Console.WriteLine("");

//2
    static int Ackermann(int n, int m)
    {
        if (n == 0) return m + 1;
        if (m == 0) return Ackermann(n - 1, 1);
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }

System.Console.WriteLine(Ackermann(2,5));

System.Console.WriteLine("");

//3
int [] Array = new int[30];

Random rnd = new Random();
System.Console.WriteLine("Исходный массив:");
for(int i = 0; i < Array.Length; ++i)
{
    int rVal = rnd.Next(1,31);
    Array[i] = rVal;
    System.Console.Write($"{Array[i]} ");
}


System.Console.WriteLine("\nRevArrayPrint:");
void RevArrayPrint(int[] ArrToPrint, int i = 0)
{
    if(i == ArrToPrint.Length - 1)
    {
        System.Console.Write($"{ArrToPrint[i]}");
        return;
    }
    RevArrayPrint(ArrToPrint,i+1);
    System.Console.Write($" {ArrToPrint[i]}");
}

RevArrayPrint(Array);