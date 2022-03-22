// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void array_on_Display(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int count_element(int[] arr)
{
    int count_element = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count_element++;
        }
    }
    return count_element;
}

int[] array = new int[123];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 1000);
}
array_on_Display(array);
int Total_count = count_element(array);
Console.WriteLine("\nКоличество елеметов на отрезке [10,99] равно:  " + Total_count);