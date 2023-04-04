//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7)
// int b = new Random().Next(2)
// Console.WriteLine($"a = {a},b = {b}");

int[] array = GetBinArray(8);
Console.WriteLine($"[ {String.Join(", ", array)} ]");

// for (int i = 0; i < array.Lenght - 1; i++){
//   Console.Write($"{array[i]}, ");
//}
// Console.Write($"{array[array.Lenght - 1]}]");

int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}