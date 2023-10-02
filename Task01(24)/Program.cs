/* На вход: Число а
На выход: сумма от 1 до а */

int SummaNumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        // Обработка исключений
        checked
        {
            sum += i;
        }   
    }
    return sum;
}

int a;
Start:
Console.Write("Введите целое число a: ");
while(!int.TryParse(Console.ReadLine(), out a))
    Console.Write("Ошибка ввода. Введите целое число: ");

if (a < 1)
{
    Console.WriteLine("Ошибка ввода");
    goto Start;
    //return;
}

int sNums = SummaNumbers(a);
Console.Write($"{a} -> {sNums} ");