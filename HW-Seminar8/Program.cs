Console.Clear();
Console.WriteLine("Введите номер задачи: 54, 56, 58, 60 или 62");
double a = Convert.ToInt32(Console.ReadLine());

//Задача 54: Задайте двумерный массив. Напишите метод, который упорядочит по убыванию элементы
//каждой строки двумерного массива. И продемонстрируйте его работу.
if (a == 54)
{
    Console.WriteLine("Решаем задачу №54");
    Console.WriteLine("Введите m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedM || !isParsedN)
    {
        Console.WriteLine("Ошибка!");
        return;
    }

    int[,] array = CreateRandom2DArray1(m, n);
    Print2DArray1(array);
    SortFromMaxArrayLines(array);
    Console.WriteLine("Отсортированный массив");
    Print2DArray1(array);
}

//Задача 56: Задайте двумерный массив. Напишите метод, который будет находить
// строку с наименьшей суммой элементов.
if (a == 56)
{
    Console.WriteLine("Решаем задачу №56");
    Console.WriteLine("Введите m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedM || !isParsedN)
    {
        Console.WriteLine("Ошибка!");
        return;
    }

    int[,] array = CreateRandom2DArray1(m, n);
    Print2DArray1(array);

    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"Cтрокa с наименьшей суммой элементов \n{minSumLine + 1}");
}

//Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц
if (a == 58)
{
    Console.WriteLine("Введите число строк 1-й матрицы:");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine("Введите число столбцов 2-й матрицы: ");
    bool isParsedP = int.TryParse(Console.ReadLine(), out int p);
    if (!isParsedM || !isParsedN || !isParsedP)
    {
        Console.WriteLine("Ошибка!");
        return;
    }

    int[,] firstMatrix = CreateRandom2DArray1(m, n);
    Console.WriteLine("Первая матрица:");
    Print2DArray1(firstMatrix);
    int[,] secondMatrix = CreateRandom2DArray1(n, p);
    Console.WriteLine("Вторая матрица:");
    Print2DArray1(secondMatrix);

    int[,] resultMatrix = new int[m, p];
    MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
    Console.WriteLine("Произведение первой и второй матриц:");
    Print2DArray1(resultMatrix);
}

//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите метод,
//который будет построчно выводить массив, добавляя индексы каждого элемента.
if (a == 60)
{
    Console.WriteLine("Решаем задачу №60");
    Console.WriteLine("Введите X:");
    bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
    Console.WriteLine("Введите Y: ");
    bool isParsedY = int.TryParse(Console.ReadLine(), out int y);
    Console.WriteLine("Введите Z: ");
    bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);
    if (!isParsedX || !isParsedY || !isParsedZ)
    {
        Console.WriteLine("Ошибка!");
        return;
    }

    int[,,] array3D = new int[x, y, z];
    FillArray3D(array3D);
    PrintArray3D(array3D);
}

//Задача 62: Напишите метод, который заполнит спирально массив 4 на 4.
if (a == 62)
{
    Console.WriteLine("Решаем задачу №62");
    int n = 4;
    int[,] sqareMatrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    Print2DArray1(sqareMatrix);
}

//метод - создает массив int
int[,] CreateRandom2DArray1(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
    return array;
}

//метод - выводит массив int
void Print2DArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//метод - сортировка строк массива от максимального элемента по убыванию
void SortFromMaxArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

//метод - нахождение суммы элементов строки
int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

//метод - произведение матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

//метод - вывод трехмерного массива
void PrintArray3D (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

//метод - заполнение трехмерного массива с указанием индекса элемента
void FillArray3D(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}