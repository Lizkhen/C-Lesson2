Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int [] array1 = {1,2,3,4,5};
int [] array2 = {6,7};
foreach (int i in array1)
{
    if (i == number)
    {
        Console.WriteLine("Рабочий");
    }
}
foreach (int a in array2)
{
    if (a == number)
    {
        Console.WriteLine("Выходной");
    }
}
if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует!!!");
}

