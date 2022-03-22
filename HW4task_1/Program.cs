// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void array_on_Display(int[] array)
{
    Console.Write("Сгенерированный массив:  " + '[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(']');
}
void Even_Odd_count(int[] array)
{
    int count_Even = 0;
    int count_Odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count_Even++;
        }
        else
        {
            count_Odd++;
        }
    }
    Console.WriteLine("\nКоличество четных чисел в массиве: " + count_Even);
    Console.WriteLine("Количество нечетных чисел в массиве: " + count_Odd);
}

/////////////////////////////////////////////////////////////////////////
int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}
array_on_Display(array);
Even_Odd_count(array);
return 0;
