/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/



double[] InitArray(int dimension)
{
  double[] array = new double[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    array[i] = rnd.Next(-100, 100) + rnd.NextDouble();
  }
  return array;
}

double Diffmaxmin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i=0; i < array.Length; i++)
    {
    if(max<array[i])
        max=array[i];

    if(min>array[i])
        min=array[i];
    }
    double diff = max-min;
    return diff;
    }
    
double [] array = InitArray(10); // выводим массив
double diff = Diffmaxmin(array); // находим разницу между макс и мин

//Math.Round(diff);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальный числом в массиве составляет: {diff} или округленно: {Math.Round(diff)}");
