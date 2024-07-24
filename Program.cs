// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.


// 1
// Метод заполнения массива:
void FeelArray(char[,] Symbols)
{
        Random rnd = new Random();
    for(int i = 0; i < Symbols.GetLength(0); i++)
    {
        for(int j = 0; j < Symbols.GetLength(1); j++)
        {
            char value = Convert.ToChar(rnd.Next(33,127));
            Symbols[i,j] = value;
        }
    }
}

char[,]Array = new char[3,3];
FeelArray(Array);

// Сделать из массива строку:
string MakeString(char[,] Array)
{
    string Result = string.Empty;
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Result += Array[i,j];
        }
    }
    return Result;
}

string MyGenericString = MakeString(Array);
System.Console.WriteLine(MyGenericString);

//2
System.Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
str = str.ToLower();
System.Console.WriteLine(str);

//3

bool IsPalindrom(string str)
{
    str = str.ToLower();
    string tempStr = "";
    for(int i = str.Length - 1; i >= 0; i--)
    {
        tempStr += str[i];
    }
    tempStr = tempStr.ToLower();
    if(tempStr == str)
    {
        return true;
    }
    else return false;
}

string str1 = "Кот";
string str2 = "Дед";
string str3 = "Комок";

System.Console.WriteLine($"str1 = {IsPalindrom(str1)}, str2 = {IsPalindrom(str2)}, str3 = {IsPalindrom(str3)}");

//4
System.Console.WriteLine("Введите строку: ");
string strWithSpaces = Console.ReadLine();
int wordCount = strWithSpaces.Split(' ').Length;
System.Console.WriteLine(wordCount);
string ReverseWordOrder(string str)
{
    string[] Words = new string[wordCount];
    string ReverseStr = "";
    int ArrCount = 0;
    string TempStr = "";
    for(int i = 0; i < str.Length; ++i)
    {
        if(str[i] == ' ')
        {
            Words[ArrCount] =TempStr;
            ArrCount++;
            TempStr = "";
            continue;
        }
        TempStr += str[i];
    }

    for(int k = Words.Length - 1; k >= 0; --k)
    {

        ReverseStr += Words[k] + " ";
    }

    return ReverseStr;
}

string Reverse = ReverseWordOrder(strWithSpaces);
System.Console.WriteLine(Reverse);