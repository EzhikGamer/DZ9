// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// ===================================НАЧАЛО===================================
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNatural(int a,int b)
{
    if(a==b) return a; 
    return a+SumNatural(a+1,b);
}

void Main()
{

    int a=ReadInt("Число А");
    int b=ReadInt("Число Б");
    if(a>b)
    {
        System.Console.WriteLine("Неверный диапазон");
        return;
    }
    System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {a} до {b} равна: {SumNatural(a,b)}");
}
// --------------------------------------------------------------------------------------------------------------
Main();
//===================================КОНЕЦ===================================