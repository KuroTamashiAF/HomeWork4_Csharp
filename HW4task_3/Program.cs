//Найти сумму чисел одномерного массива стоящих на нечетной позиции
int Entered_options_Volume()
{
    Console.Write("Введите размерность массива:  ");
    int Vol = int.Parse(Console.ReadLine());
    return Vol;
}
int Entered_options_Maximum()
{
    Console.Write("\nВведите максимальное значение чисел в массиве:  ");
    int Maximum = int.Parse(Console.ReadLine());
    return Maximum;
}
int Entered_options_Minimum()
{
Console.Write("\nВведите минимальное  значение чисел в массиве:  ");
int Minimum = int.Parse(Console.ReadLine());
return Minimum;
}
void array_on_Display(int[] arr)
{
    Console.Write("Сгенерированный массив:  " + '[');
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write(']');
}
int Odd_element_sum(int[] ar)
{
    int sum_odd = 0;
    for (int i = 1; i < ar.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum_odd += ar[i];
        }
    }
    return sum_odd;
}
int Vol = Entered_options_Volume();
int Max = Entered_options_Maximum();
int Min = Entered_options_Minimum();
int[] array = new int[Vol];
Random rnd = new Random();
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(Min, Max);
}
array_on_Display(array);
int total_sum = Odd_element_sum(array);
Console.WriteLine("\nСумма элемнтов массива стоящих на нечетных позициях равна :  " + total_sum);