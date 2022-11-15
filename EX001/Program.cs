// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 

// 1. получить число(сток/столбцов) 
int Numb(string text) 
{ 
    Console.WriteLine("Введите " + text); 
    int N = Convert.ToInt32(Console.ReadLine()); 
    return N; 
} 
// 2. создать двумерный массив 
int[,] CreateArray(int m, int n) 
{ 
    return new int[m, n]; 
} 
// 3. заполнить полученный массив 
void FillArray(int[,] arr, int min, int max) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { arr[i, j] = new Random().Next(min, max); } 
    } 
} 
// 4. напечатать массив 
void Print(int[,] ar) 
{ 
    for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine(" ")) 
    { 
        for (int j = 0; j < ar.GetLength(1); j++) 
        { Console.Write(ar[i, j] + "\t"); } 
    } 
} 
 
// 5. отсортировать по уменьшению массив 
void SortingArrayRowMin(int[,] array) 
{ 
    int temp; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            for (int a = j + 1; a < array.GetLength(1); a++) 
            { 
                if (array[i, j] > array[i,a]) 
                { 
                    temp = array[i, j]; 
                    array[i, j] = array[i, a]; 
                    array[i, a] = temp; 
                } 
            } 
 
 
        } 
    } 
} 
 
 
Console.Clear(); 
int Row = Numb("количество строк"); 
int Column = Numb("количество столбцов"); 
int[,] array = CreateArray(Row, Column); 
Console.WriteLine(); 
FillArray(array, 0, 25); 
Print(array); 
SortingArrayRowMin(array); 
Console.WriteLine(); 
Print(array);