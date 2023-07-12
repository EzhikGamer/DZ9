// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// ===================================НАЧАЛО===================================
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int akker(int c, int d)
{
    if (c == 0) return d + 1;
    if (c > 0 && d == 0) return akker(c - 1, 1);
    if (c > 0 && d > 0) return akker(c - 1, (akker(c, d - 1)));
    return akker(c, d);
}

void Main()
{
    int a = ReadInt("Введите число A");
    int b = ReadInt("Введите число B");
    if (a < 0 || b < 0) System.Console.WriteLine("Введены неверные значения");
    else System.Console.WriteLine($"Значение функции Аккермана равно: {akker(a, b)}");
}
// -----------------------------------------------------
Main();
//===================================КОНЕЦ===================================