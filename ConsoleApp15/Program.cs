/*
Даны натуральные n, a1,..., an(n >=4) числа a1..., an – это измеренные в сотых долях 
секунды результаты n спортсменов в беге на 100 м. Составить команду из четырех лучших 
бегунов для участия в эстафете 4х100, т. е. указать одну из четверок натуральных чисел i, 
j, k, l такую, что сумма a1+aj+ak+ac имеет наименьшее значение. 
*/

int n = 6;

int[] timesArray = { 1250, 1300, 1100, 1450, 1200, 1150 };

int minTime = int.MaxValue;
int bestI = 0, bestJ = 0, bestK = 0, bestL = 0;

for (int i = 0; i < n - 3; i++)
{
    for (int j = i + 1; j < n - 2; j++)
    {
        for (int k = j + 1; k < n - 1; k++)
        {
            for (int l = j + 1; l < n; l++)
            {
                int sum = timesArray[i] + timesArray[j] + timesArray[k] + timesArray[l];

                if (minTime > sum)
                {
                    minTime = sum;
                    bestI = i;
                    bestJ = j;
                    bestK = k;
                    bestL = l;
                }
            }
        }
    }
}
    // вывод результата
    Console.WriteLine("Лучшие спортсмены: ");
    Console.WriteLine($"Индексы: {bestI}, {bestJ}, {bestK}, {bestL}");
    Console.WriteLine($"Результаты: {timesArray[bestI]}, {timesArray[bestJ]}, {timesArray[bestK]}, {timesArray[bestL]}");
    Console.WriteLine($"Минимальная сумма: {minTime}");


