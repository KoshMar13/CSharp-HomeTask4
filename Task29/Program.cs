// 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-1000, 1001);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b");
    Console.Write("\b");
    Console.Write("]");
}

int[] numbers = new int[8];
PrintArr(Array(numbers));

// Console.WriteLine("[{0}]", string.Join(",", Array(numbers))); Печать чётко по заданию, но в строку.
