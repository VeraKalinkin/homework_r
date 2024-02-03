//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 & n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    Console.WriteLine("Ошибка");
    return 0;
}

int m = 4;
int n = 4;
int functionAckermann = Ackermann(m, n);
Console.Write(functionAckermann);