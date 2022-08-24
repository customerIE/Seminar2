int number = new Random().Next(1,65537);
int index = 0;
int digit = 0;
Console.WriteLine($"Случайное число = " + number);
// Подсчет количества цифр
int num = number;
while (num != 0) 
{
    int dig = num % 10;
    num = num/10;
    index++;
}
Console.WriteLine($"Количество цифр = " + index);
if (number >= 100 && number <=999)
{
    digit = number % 10;
    number = number/10;
}
if (number >= 1000 && number <=9999)
{
    digit = number % 10;
    number = number/10;
    digit = number % 10;
}
if (number >= 10000 && number <=65537)
{
    digit = number % 10;
    number = number/10;
    digit = number % 10;
    number = number/10;
    digit = number % 10;
}
if (number < 100 )
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.WriteLine($"Третья цифра = " + digit);
}