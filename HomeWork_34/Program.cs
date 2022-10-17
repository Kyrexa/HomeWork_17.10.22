// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Написать программу, которая покажет количество четных чисел в массиве.
Console.WriteLine("Напишите размер  массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
NewArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"{numbers.Length} числа, {count} числа чётные");
void NewArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}