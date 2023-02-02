/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] InitArray(int dimension)
{
  int[] array = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    array[i] = rnd.Next(100, 1000);
  }
  return array;
}


int FindEvenCount(int[] array)
{
  var count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      count++;
  }
  return count;
}

int [] array = InitArray(10);
int count = FindEvenCount(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"В указанном массиве находится {count} четных чисел.");
