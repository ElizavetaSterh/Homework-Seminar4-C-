// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(string number) // преобразует в массив и выдает сумму
{
    int[] arr = new int[number.Length];
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        arr[i] = int.Parse(number[i].ToString());
        sum = sum + arr[i];
    }
    return sum;
}
string Digit(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}
string num = Digit("Введите число: ");
int sumValue = SumNumbers(num);
Console.Write($"Сумма цифр числа {num} равна: {sumValue}");