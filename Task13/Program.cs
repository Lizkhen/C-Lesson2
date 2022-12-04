Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = -number;
string str = number.ToString();
int[] Array = new int[str.Length];
int strLen = str.Length;
for ( int i=0; i< str.Length; i++)
{ 
    Array[i] = Convert.ToInt32(str[i].ToString()); 
}
if (strLen < 3 )
{
    Console.WriteLine ("Нет третьей цифры!");
}
else
    Console.WriteLine (Array[2]); 