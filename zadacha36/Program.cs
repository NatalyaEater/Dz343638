//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(4,-100,100);
int oddSum=0;

for (int i=1; i<array.Length; i=i+2)
{
    
    oddSum=oddSum+array[i];
    
}
Console.WriteLine();
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях равна  {oddSum} ");