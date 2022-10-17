// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Напишите размер  массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
NewArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i = i + 2)
    sum = sum + numbers[i];

    Console.WriteLine($"{numbers.Length} числа, сумма элементов, стоящих на нечётных позициях = {sum}");
void NewArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-10 ,100);
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