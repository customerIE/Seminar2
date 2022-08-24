int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число = " + number);
Console.WriteLine($"Второе число = " + GetDigit(number));
int GetDigit(int num)
{
    int digit = num % 10;
    num = num/10;
    int number_2 = num % 10;
    return number_2;
}


