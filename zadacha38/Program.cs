// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double [size];
    for (int i=0; i<size; i++)
    {
        res[i]= Convert.ToDouble(new Random().Next(minValue, maxValue));
        Console.Write($"{res[i]} ");
    }
    return res;
}

double[] array = GetArray(6, 0, 99);

double Min=array[0];
double Max=array[0];

for (int i=0; i<array.Length; i++)
{
    if (array[i]>Max)
    {
    Max=array[i];
    }
    if (array[i]<Min)
    {
    Min=array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Максимальное значение {Max}   Минимальное значение  {Min} ");
Console.WriteLine($"Разница между значениями {Max-Min} ");