/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
0   1   2   3
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

1. Задайте одномерный массив, заполненный случайными числами.
2. Найдите элементы, стоящие на нечетных позициях и найдите сумму этих элементов.*/

int[] InitArray(int dimension)
{
  int[] array = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    array[i] = rnd.Next(-100, 100);
  }
  return array;
}


int FindOddElements(int[] array)
{
  int oddsum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
oddsum += array[i];
    }
  return oddsum;
}

int [] array = InitArray(10);
int oddsum = FindOddElements(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма чисел с нечетным индексом = {oddsum}");
