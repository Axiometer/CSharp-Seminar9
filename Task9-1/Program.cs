// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии

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

// Рекурсионный вывод
void WriteNumbersFromMToN(int m, int n)
{
    if (m % 2 != 0)
        m ++;

    if (n < m && m % 2 == 0)
        return;

    Console.Write(m + " ");
    WriteNumbersFromMToN(m + 2, n);
}

System.Console.WriteLine("Вывод всех чётных натуральных чисел в промежутке от M до N с помощью рекурсии.");
int M = GetNumberFromUser("Введите нижний порог M: ");
int N = GetNumberFromUser("Введите верхний порог N: ");

WriteNumbersFromMToN(M, N);
