// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента. 

// 1. получить число(сток/столбцов) 
int Numb(string text) 
{ 
    Console.WriteLine("Введите " + text); 
    int N = Convert.ToInt32(Console.ReadLine()); 
    return N; 
} 
// 2. создать двумерный массив 
int[,,] CreateArray(int x, int y, int z) 
{ 
    return new int[x, y, z]; 
} 
// 3. заполнить полученный массив  

void FillArray(int[,,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
          int k = 0; 
            while (k < arr.GetLength(2)) 
            { 
                int element = new Random().Next(arr.GetLength(0)*arr.GetLength(1) *arr.GetLength(2)+ 1); 
                if (FindElement(arr, element)) continue; 
                arr[i, j, k] = element; 
                k++; 
            } 
 
        } 
    } 
 
} 
 
bool FindElement(int[,,] array, int el) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            for (int k = 0; k < array.GetLength(2); k++) 
            { 
                if (array[i, j, k] == el) return true; 
            } 
        } 
    } 
    return false; 
} 
// 4. напечатать массив 
void Print(int[,,] ar) 
{ 
    for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine(" ")) 
    { 
        for (int j = 0; j < ar.GetLength(1); j++) 
        { 
            for (int k = 0; k < ar.GetLength(2); k++) 
            { 
                Console.Write($"{ar[i, j, k]} ({i},{j},{k})\t"); 
            } 
        } 
    } 
} 
 
// 5. отсортировать по уменьшению массив 
  
Console.Clear(); 
int X = Numb("количество строк (Х)"); 
int Y = Numb("количество столбщов (Y)"); 
int Z = Numb("Глубину матрицы (Z)"); 
int[,,] array = CreateArray(X, Y, Z); 
Console.WriteLine(); 
//FillArray(array, 0, 1000); 
FillArray(array); 
Print(array);