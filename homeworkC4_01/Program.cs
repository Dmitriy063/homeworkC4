// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int step(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}
int numberA = Prompt("Введите a: ");
int numberB = Prompt("Введите b: ");
int result1 = step(numberA, numberB);
Console.WriteLine("Ответ: " + result1);



