//Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите число больше нуля: ");
int size = int.Parse(Console.ReadLine()!);

int counter = 0;
int[] numbers = new int[size];
numbers = InputNumbers(numbers, numbers.Length);
PrintArray(numbers);
Console.WriteLine();
FindPositive(numbers, numbers.Length, counter);


int[] InputNumbers (int[] numbers, int size)
{
    if (size > 0) 
    {
        Console.Write($"Введите {numbers.Length - size + 1} целое число: ");
        numbers[numbers.Length - size] = int.Parse(Console.ReadLine()!);
        return InputNumbers(numbers, --size);
    }
    else return numbers;
}

void FindPositive (int[] numbers, int size, int counter)
{
    if (size > 0) 
    {
        if (numbers[numbers.Length - size] > 0) counter++;
        FindPositive(numbers, --size, counter);
    }
    else Console.WriteLine($"Количество введенных положительных чисел: {counter}");
}

void PrintArray(int[] x)
{
    int[] new_array = x;
    for (int i = 0; i < new_array.Length; i++)
        Console.Write($"{new_array[i]} ");
}

