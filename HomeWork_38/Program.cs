// Задайте массив вещесвенных чисел.Найдите разницу между максимальным и минимальным элементом массива.
// Внутренние функции использовать нельзя (Max и Min)
Console.Clear();
Console.WriteLine("Напишите размер  массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
NewArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
void NewArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(10 ,100);
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
int max, min;
max = min = numbers[0]; // сокращённая запись
for (int i = 0; i < numbers.Length; i++)
{
    if (max < numbers[i]) max = numbers[i]; 
    if (min >numbers[i]) min =numbers[i];
}
Console.WriteLine($" {numbers.Length} чисел. Макc значение = {max}, мин значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");