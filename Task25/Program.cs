// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 
void GetNumb(int num1, int num2)
{
    int k = num1;
    for (int i = 1; i < num2; i++)
    {
        k = k*num1;
    }
    Console.WriteLine($"{num1}, {num2} -> {k}");
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int numberA = GetInput("Введите число A: ");
int numberB = GetInput("Введите число B: ");
GetNumb(numberA, numberB);