// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 

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
        { Console.Write(ar[i,j] + "\t"); } 
    } 
} 
 
// 5. находить строку с наименьшей суммой элементов 
void FindMinSunRowArray(int[,]array) 
{ 
    string text="Строка с наименьшей суммой элементов - это строка: № "; 
    int sumMin=1; 
     for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(" ")) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { int sum=0; 
        sum=array[i,j]; 
        if(sum<sumMin) sumMin=i+1; 
        } 
    } 
    Console.WriteLine(text+sumMin); 
} 
 
 
Console.Clear(); 
int Row=Numb("количество строк"); 
int Column=Numb("количество столбщов"); 
int[,]array=CreateArray(Row,Column); 
Console.WriteLine(); 
FillArray(array,0,25); 
Print(array); 
FindMinSunRowArray(array);