/*
Записать элементы матрицы построчно в одномерный массив и найти его 
минимальный элемент.
*/

//задаем двумерную матрицу
int[,] matrix = {
    { 5, 12, 7 },
    { 3, 8, 15 },
    { 10, 6, 2 }
};

//вычисляем размеры матрицы
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);

//создаем одномерный массив
int[] array = new int[rows * cols];

//записываем элементы матрицы построчно в одномерный массив
int index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[index] = matrix[i, j];
        index++;
    }
}

//находим минимальный элемент в одномерном массиве
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

//выводим одномерный массив
Console.WriteLine("Одномерный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

//выводим минимальный элемент
Console.WriteLine("Минимальный элемент: " + min);