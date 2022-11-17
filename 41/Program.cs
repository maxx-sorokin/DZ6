// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел будете вводить?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Отлично, теперь можете ввести {m} чисел");

int[] numbers = EnteringArray(m);
PrintArray(numbers);

Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbersInArray(numbers)}");

int CountPositiveNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] EnteringArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        bool isParsedElement = int.TryParse(Console.ReadLine(), out int element);

        if (!isParsedElement)
        {
            Console.WriteLine("Ошибка! Не правильно введены данные, попробуйте ещё раз");
            i -= 1;
        }
        else
        {
            array[i] = element;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}