// Напишите программу, которая принимает на вход число и выдаёт
//сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write ("Введите число: ");
int num = int.Parse (Console.ReadLine ());
Console.WriteLine($"{num} --> {a(num)}");

int a(int number)  // создали метод а который работает от какого то int, и это не 
{                   // обязательно num как по условию задачи, а он как бы обезличен
    int sum = 0;
    while(number>0)
    {
        sum = sum + number%10;
        number/=10;

    }
    return sum;
}

