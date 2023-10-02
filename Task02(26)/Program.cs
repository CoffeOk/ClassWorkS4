/* На вход: Число n
На выход: количество цифр в числе */

int KolNums (int num)
{
    if (num == 0) return 1;
    int kol = 0;
    while (num != 0)
    {
        num /= 10;
        kol += 1;
    }
    return kol;
}

int n;
Console.Write("Введите целое число n: ");
while(!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Ошибка ввода. Введите целое число: ");



int countNum = KolNums (n);
Console.Write($"{n} -> {countNum} ");