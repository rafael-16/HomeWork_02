var array_A = new int[5];
double[,] array_B = new double[3, 4];
var random = new Random();

// 1------------ объявляем и показываем массивы
for (int i = 0; i < array_A.Length; i++)
{
    Console.Write("Введите " + (i + 1) + "-е число: ");
    array_A[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array_B.GetLength(0); i++)
{
    for (int j = 0; j < array_B.GetLength(1); j++)
    {
        array_B[i, j] = Math.Round(random.NextDouble() * 20, 1);
    }
}

Console.WriteLine("\nПервый массив.");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("[ ");
foreach (int i in array_A)
{
    Console.Write($"{i} ");
}
Console.Write("]\n");
Console.ResetColor();

Console.WriteLine("\nВторой массив.");
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < array_B.GetLength(0); i++)
{
    for (int j = 0; j < array_B.GetLength(1); j++)
    {
        Console.Write(array_B[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.ResetColor();

// 2------------ максимальный и минимальный элемент в массивах
double max_nam1 = (double)array_A.Max();
double max_num2 = (from double a in array_B select a).Max();

Console.ForegroundColor = ConsoleColor.Blue;
if (max_nam1 > max_num2)
    Console.WriteLine("\nmax число в массивах: " + max_nam1);
else Console.WriteLine("\nmax число в массивах: " + max_num2);
Console.ResetColor();

double min_num1 = (double)array_A.Min();
double min_num2 = (from double a in array_B select a).Min();

Console.ForegroundColor = ConsoleColor.Green;
if (min_num1 < min_num2)
    Console.WriteLine("\nmin число в массивах: " + min_num1);
else Console.WriteLine("\nmin число в массивах: " + min_num2);
Console.ResetColor();

// 3------------ сумма элементов массивов
double sum_a = (double)array_A.Sum();
double sum_b = (from double b in array_B select b).Sum();

Console.WriteLine("\nSum:                      " + Math.Round(sum_a + sum_b, 1));

// 4------------ произведение массивов
double res_a = 1;
double res_b = 1;

for (int i = 0; i < array_A.Length; i++)
    res_a = res_a * array_A[i];

for (int i = 0; i < array_B.GetLength(0); i++)
    for (int j = 0; j < array_B.GetLength(1); j++)
        res_b = res_b * array_B[i, j];

Console.WriteLine("Result:                  " + Math.Round(res_a * res_b, 1));

// 5------------ сумма четных массива А
int sum_of_even = 0;
for (int i = 0; i < array_A.Length; i++)
    if (array_A[i] % 2 == 0)
        sum_of_even += array_A[i];
Console.WriteLine("Sum of even in array A:  " + sum_of_even);

// 6------------ сумма нечетных столбцов массива В
double sum_of_odd = 0;
for (int i = 0; i<array_B.GetLength(0) ; i++)
    for (int j = 0;j < array_B.GetLength(1) ; j+=2)
        sum_of_odd += array_B[i, j];
Console.WriteLine("Sum of odd in array B:   " + Math.Round(sum_of_odd,1));