// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NumbersToN(int number1, int number2)
{
    
    if(number1>number2) return number2;
    
    else
    {
        Console.Write(number1+ ", ");
        number1++;
    
    }
    
    return NumbersToN(number1++, number2);

}

Console.WriteLine("Enter N: ");
int numStart = 1;
int numFinish = Convert.ToInt32(Console.ReadLine());

NumbersToN(numStart,numFinish);