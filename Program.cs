/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
int[] GetArray (int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = new Random ().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] ReverseArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++) // i < size = i < array.Length
    {
        arr[i] *= (-1); // arr[i] = arr[i] * (-1)
    }  
    return arr;
}    

int [] array = GetArray(11, -9, 9);

Console.WriteLine($"Массив              : [ {String.Join("; ", array)} ]");
Console.WriteLine($"Массив Перевернутый : [ {String.Join("; ", ReverseArray(array))} ]");