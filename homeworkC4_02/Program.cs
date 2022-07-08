// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
int number = Prompt("Введите A: ");
int result = SumDigits(number);
System.Console.WriteLine(result);
