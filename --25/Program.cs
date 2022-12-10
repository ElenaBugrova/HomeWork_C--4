//Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)


Console.Write ("Введите число A: ");
int A = int.Parse (Console.ReadLine ());
Console.Write ("Введите число B: ");
int B = int.Parse (Console.ReadLine ());
Console.WriteLine(result(A,B));


//double Result = Math.Pow (A, B);

int result (int number, int power)
{
    int mtpl=1;                     
    for (int i=1; i<=power; i++)     
    mtpl = mtpl*number;    
return mtpl;
}


