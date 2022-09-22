//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int ost = num1 % 2 ;
if (ost == 1 )
{
    Console.WriteLine("Число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}

