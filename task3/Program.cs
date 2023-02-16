// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76




double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        double temp = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
        array[i] = temp;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("Array: [" + string.Join(" | ", array) + "]");
}

void DifferenceBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[0 + i])
        {
            max = array[0 + i];
        }
    }
    System.Console.WriteLine($"max: {max}");
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[0 + i])
        {
            min = array[0 + i];
        }
    }
    System.Console.WriteLine($"min: {min}");
    double diff = max - min;
    System.Console.WriteLine($"Difference between max and min: {diff}");
}

double[] array = FillArrayWithRandomNumbers(5, -10, 10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Check, seconf element: {array[2]}");
System.Console.WriteLine();
DifferenceBetweenMaxAndMin(array);