// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

ArrayFindPositiveNumber(array);
Console.WriteLine("Полученный массив: ");
OutputArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        {
            count++;
        }
}

Console.WriteLine($"Количество четных чисел в полученном массиве - {count}");

void ArrayFindPositiveNumber(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void OutputArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
ArrayRandomNum(numbers);
Console.WriteLine("Полученный массив: ");
OutputArray(numbers);

int sum = 0;

for (int i = 1; i < numbers.Length; i+=2)
{
    sum = sum + numbers[i];
}
    Console.WriteLine($"Сумма элементов на нечётных позициях полученного массива - {sum}");

void ArrayRandomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-10,10);
        }
}

void OutputArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
ArrayRandomNum(numbers);
Console.WriteLine("Полученный массив: ");
OutputArray(numbers);

int comp = 0;
// 
for (int i = 0; i < numbers.Length;  i++)
{
    if(i < size / 2)
    {
        comp = numbers[i] * numbers[size-1-i];
        Console.WriteLine($"Произведение пар чисел - {comp}");
    }
}

void ArrayRandomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}

void OutputArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
ArrayRandomNum(numbers);
Console.WriteLine("Полученный массив: ");
OutputArray(numbers);

double maxNumb = numbers[0];
double minNumb = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (maxNumb < numbers[i])
    {
        maxNumb = numbers[i];
    }
        if (minNumb > numbers[i])
        {
            minNumb = numbers[i];
        }
}

double diff = maxNumb - minNumb;

Console.WriteLine($"Разница между максимальным ({maxNumb}) и минимальным ({minNumb}) элементами: {diff}");

void ArrayRandomNum(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round((new Random().NextDouble() + new Random().Next(-10,10)),2);
    }
}

void OutputArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}