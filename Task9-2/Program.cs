// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

// Ввод числа пользователем
int GetNumberFromUser(string message)
{
    while(true)     
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)       
            return userNumber;
        Console.WriteLine("Ошибка ввода!");
    }
}

// Рекурсионный подсчет суммы
int SumMN(int m, int n)
{
    if (m > n) 
        return 0;
    return n + SumMN(m, n - 1);
}

System.Console.WriteLine("Сумма натуральных элементов в промежутке от M до N");
int M = GetNumberFromUser("Введите первое число  M: ");
int N = GetNumberFromUser("Введите последнее число N: ");

System.Console.Write($"Сумма натуральных чисел от {M} до {N} равна {SumMN(M, N)}");

