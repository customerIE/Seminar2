int number = new Random().Next(1,1000000);
int a = number%23;
int b = number%7;
if (a + b == 0 )
{
    Console.WriteLine($"Число " + number + " одновременно кратно 7 и 23.");
} 
else
{
    Console.WriteLine($"Число " + number + " не кратно одновременно 7 и 23.");
}
