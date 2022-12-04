Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a = (number % 100) / 10;
if (a < 0)
{
    a = -a;
}
if (number/100 < 1||number/100 > 10)
{
    Console.WriteLine("Нет-нет-нет! Только ТРЁХЗНАЧНОЕ число!!!");
}
else 
    Console.WriteLine ("Вторая цифра " + a);