/* На вход: Число n
На выход: произведение от 1 до n */

int ProizvedNumbers (int num)
{
    int przvd = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            przvd += i;
        }   
    }
    return przvd;
}

int n;
Start:
Console.Write("Введите целое число n: ");
while(!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Ошибка ввода. Введите целое число: ");

if (n < 1)
{
    Console.WriteLine("Ошибка ввода");
    goto Start;
    //return;
}

int pNums = ProizvedNumbers(n);
Console.Write($"{n} -> {pNums} ");