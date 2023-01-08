// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет числа в промежутке от M до N 
// c шагом 0,2. Выполнить с помощью рекурсии.

Console.WriteLine ("Введите число M");
double m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число N");
double n = Convert.ToInt32(Console.ReadLine());

if (m.CompareTo(n)==0) 
{
    Console.WriteLine("M=N. Введите другие числа.");
    return;
}

string PrintNum (double start, double end)
{
    int status = start.CompareTo(end);
    if (status == 0) 
    {
        return Convert.ToString(end);
    } else if (status<0)
    {
        return (start + " " + PrintNum (start = Math.Round(start+0.2,2),end) );
    }
    else 
    return (start + " " + PrintNum (start = Math.Round(start-0.2,2),end) );
}


// -------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

string PrintSum (int start, int end, int temp)
{
    if (start == end) 
    {
        return Convert.ToString(temp+end);
    }
    else
    {
        return PrintSum (start+1,end, temp+start);
    }   
}


// -------------------------------------------
// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akerman (int M, int N)
{
    if (M == 0) 
    {
        return N + 1;
    }
    else if ((M != 0) && (N == 0))
    {
        return Akerman(M - 1, 1);
    }
    else
    {
        return Akerman(M - 1, Akerman(M, N - 1));
    }
      
}


// ----------------------------------------

// Вызов задачи 64
// Console.WriteLine (PrintNum(m,n));

// Вызов задачи 66
//Console.WriteLine (PrintSum(Convert.ToInt32(m),Convert.ToInt32(n),0));

// Вызов задачи 68
Console.WriteLine (Akerman(Convert.ToInt32(m),Convert.ToInt32(n)));