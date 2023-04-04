//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");

int GetMultiply(int n)
{ // n=3
int result = 1;
//int i=2;
// if( n < 0)
// {
//       i = n;
//        n = -1;
// }
     for (int i = 2; i <= n; i++)
     { // i <= n; 2 <= 3
        result *= i; 
}
return result;
}