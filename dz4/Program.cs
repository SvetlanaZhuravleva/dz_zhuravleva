//Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число больше 0");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int num1 = 0;
    while (num >= num1)
    {
        Console.Write(num1 + ",");
        num1 = num1 + 2;
    }

}
else
{
    Console.WriteLine("Больше 0, умник");
}

