
int[,] array = new int[5, 5];
var random = new Random();
var min_num = array[0, 0];
var max_num = array[0, 0];

var index_min = (0, 0);
var index_max = (0, 0);

int sum = 0;

// ---- заполняем массив случайными числами
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = random.Next(-100, 100);

// ---- демонстрация массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < 0)
            Console.Write(array[i, j] + "\t");
        else Console.Write(" " + array[i, j] + "\t");
    }
    Console.WriteLine();
}

// ---- ищем минимальный и максимальный элементы
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min_num)
        {
            min_num = array[i, j];
            index_min = (i, j);
        }
        if (array[i, j] > max_num)
        {
            max_num = array[i, j];
            index_max = (i, j);
        }
    }
}
Console.WriteLine("\nmin:\t" + min_num + $"\tindex: [{index_min}]");
Console.WriteLine("max:\t" + max_num + $"\tindex: [{index_max}]");

// ---- суммируем элементы между минимальным и максимальным

bool flagcount = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == min_num || array[i, j] == max_num)
        {
            if (flagcount)
            {
                flagcount = false;
            }
            else
            {
                flagcount = true;
            }
        }
       else if (flagcount)
            sum += array[i, j];
    }
}


    Console.WriteLine("\nSum:\t" + sum);