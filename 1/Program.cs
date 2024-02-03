//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Countdown(int M, int N)
{
    if (N < M)
    {
        return;
    }
    else
    {
        Countdown(M, N - 1);
    }
    Console.Write($"{N}, ");
}

int M = 7;
int N = 17;
Countdown(M, N);