// Дана последовательность из N целых чисел и число K.
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо,
// если K – положительное и влево, если отрицательное.

void PrintArray(int[] collection)
{
    Console.WriteLine();
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i]);
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число K");
int K = int.Parse(Console.ReadLine());

int[] Array = new int[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введите число: ");
    Array[i] = int.Parse(Console.ReadLine());
}

int mem;
if (K>0)
{
    for (int i = 0; i < K; i++)
    {
        for (int j = N-1; j > 0; j--)
        {
            mem = Array[j];
            Array[j] = Array[j-1];
            Array[j-1] = mem;
        }
    }
    PrintArray(Array);
}
else if (K<0)
{
    K = K*-1;
   for (int i = 0; i < K; i++)
    {
        for (int j = 0; j < N-1; j++)
        {
            mem = Array[j];
            Array[j] = Array[j+1];
            Array[j+1] = mem;
        }
    } 
    PrintArray(Array);
}
else PrintArray(Array);