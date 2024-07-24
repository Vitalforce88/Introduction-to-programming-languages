// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void Multiplicity(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        System.Console.WriteLine("Число кратно 7ми и 23м");
    }
    else
    {
        System.Console.WriteLine("Не кратное 7ми и 23м число");
    }
}

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.

int CoordinateQuarter(int x, int y)
{

    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0)
    {
        return 4;
    }
    else return 0;

}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

void LagestInTwoDigitNumber()
{
    System.Console.WriteLine("Enter number on the segment [10,99]:");
    int x = Convert.ToInt32(Console.ReadLine());
    while(x < 10 || x > 99)
    {
        System.Console.WriteLine($"You entered the number {x} -> it is not included in the segment [10,99]\nEnter number again:");
        x = Convert.ToInt32(Console.ReadLine());
    }
    int dozens = x / 10;
    int units = x % 10;

    if(dozens > units) System.Console.WriteLine($"The Lagest number of two-digit number is -> {dozens}");
    if(dozens < units) System.Console.WriteLine($"The Lagest number of two-digit number is -> {units}");
    if(dozens == units) System.Console.WriteLine($"The numbers of two-digit number {dozens}{units} are equal");
}

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

//int x = 1569889902;
// int[] digits = new int[1 + (int)Math.log10(x)];
// for (int i = digits.length - 1; i >= 0; i--)
// {
//     int digit;
//     x = Math.DivRem(x, 10, out digit);
//     digits[i] = digit;
// }
// int[]digits = Array.ConvertAll(x.ToString("0").ToCharArray(),ch => ch - '0');
// foreach( int e in digits)
// {
//     System.Console.Write($"{e},");
// }



//1:
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Multiplicity(num);

//2:
System.Console.Write("Enter X coordinate( > 0 ): ");
int x = Convert.ToInt32(Console.ReadLine());
while(x == 0){
    System.Console.Write("Enter X coordinate( > 0 ): ");
    x = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("Enter Y coordinate( > 0 ): ");
int y = Convert.ToInt32(Console.ReadLine());
while(y == 0){
    System.Console.Write("Enter Y coordinate( > 0 ): ");
    y = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine($"Coordinate quarter -> {CoordinateQuarter(x,y)}");

//3:
 LagestInTwoDigitNumber();

 // 4:
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}


