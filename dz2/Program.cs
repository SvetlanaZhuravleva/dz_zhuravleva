


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"Число {num1} максимальное");
    }
    else
    {
        Console.WriteLine($"Число {num3} максимальное");
    }
}
else if (num2 > num3)
{
    Console.WriteLine($"Число {num2} максимальное");
}
else 
{
    Console.WriteLine($"Число {num3} максимальное");
}
