// Вывод массива из 0 и 1 рассположенных в случайном порядке

// Создаём массив
int[] RandomArray (int min, int max, int length)
{
    int[] arr = new int [length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr [i] = rnd.Next (min, max +1);        
    }
    return arr;
}

// Вывод массива
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = RandomArray(0, 1, 8);
PrintArray(array);