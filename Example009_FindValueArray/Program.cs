// заполнение массива случайными числами от 1 до 99
void fillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 99);
        index++;
    }
}

// печать массива
void printArray(int[] collection)
{
    Console.WriteLine("Случайный массив длинной в " + collection.Length + " состоит из: ");
    int index = 0;
    while (index < collection.Length)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
    Console.WriteLine();
}

// Поиск числа в массиве
int findValue(int[] collection, int value)
{
    int index = 0;
    int position = -1;
    while (index < collection.Length)
    {
        if (collection[index] == value)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int lenghtArray = new Random().Next(10, 20); // случайная длинна массива

int[] array = new int[lenghtArray]; // создаем пустой массив случайной длинны

fillArray(array); // заполняем массив случайными числами

printArray(array); // выводим массив на экран

Console.WriteLine("Поиск числа в случайном массиве");
Console.WriteLine("Введите искомое число:");
int value = Convert.ToInt32(Console.ReadLine());

if (findValue(array, value) != (-1))
{
    Console.WriteLine("Искомое значение: " + value + " находится по индексу " + findValue(array, value));
}
else
{
    Console.WriteLine("Искомое значение : " + value + " НЕ найдено!");
}

