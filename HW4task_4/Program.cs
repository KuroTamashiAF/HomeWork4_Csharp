// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void array_on_Display(int[] arr)
{
    Console.Write("Сгененрированный массив " + '[');
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
    Console.Write(']');
}
int Entered_size()
{
    Console.Write("Введите размер массива: ");             // размер массива желательно вводить четным 
    int Size = int.Parse(Console.ReadLine());              // что бы все елементы массива имели пару
    return Size;                                           // в противном случае, один из елементов массива 
}                                                          // останеться без пары и не будет участвовать в расчете!!!
int Entered_Maximum()
{
    Console.Write("Введите максимальное допустимое значение в массиве : ");
    int Maximum = int.Parse(Console.ReadLine());
    return Maximum;
}
int Entered_Minimum()

{
    Console.Write("Введите минимальное значение в массиве : ");
    int Minimum = int.Parse(Console.ReadLine());
    return Minimum;
}
int size = Entered_size();
int Max = Entered_Maximum();
int Min = Entered_Minimum();
int[] array = new int[size];           
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(Min, Max+1);
}
array_on_Display(array);
Console.WriteLine();
int position = 0;
for (int i = 0; i < array.Length / 2; i++)
{
    int product = array[i] * array[array.Length - 1 - i];
    position++;
    Console.Write("\nПроизведение пары №" + position + " равно " + product);
}
