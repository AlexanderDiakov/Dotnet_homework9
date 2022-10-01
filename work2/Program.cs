// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");

void FindSumNumber(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"сумма натуральных элементов в промежутке от m до n = {sum} ");
        return;
    }
    sum = sum + (m++);
    FindSumNumber(m, n, sum);
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

FindSumNumber(m, n, 0);