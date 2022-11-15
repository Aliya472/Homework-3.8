// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 

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
 
// 5. произведение двух матриц 
 
void Multipliction_Array(int[,]a1,int[,]a2) 
{ 
    int ia3=a1.GetLength(0); 
    int ja3=a2.GetLength(1); 
    if (a1.GetLength(1)!=a2.GetLength(0)) Console.Write("Умножить эти массивы не получается");  
    else {int[,]a3=new int[ia3,ja3]; 
    for (int i = 0; i < ia3; i++) 
    { 
        for (int j = 0; j < ja3; j++) 
        { 
            for (int k = 0; k < a2.GetLength(0); k++) 
            { 
                a3[i,j]=a3[i,j]+a1[i,k]*a2[k,j]; 
            }} 
        }Print(a3); 
    }     
} 
 
 
Console.Clear(); 
int Row1=Numb("количество строк первого массива"); 
int Column1=Numb("количество столбщовпервого массива"); 
int[,]array1=CreateArray(Row1,Column1); 
FillArray(array1,0,10); 
 
int Row2=Numb("количество строк второго массива"); 
int Column2=Numb("количество столбщов второго массива"); 
int[,]array2=CreateArray(Row2,Column2); 
FillArray(array2,0,10); 
 
Console.WriteLine(); 
Print(array1); 
Console.WriteLine(); 
Print(array2); 
Console.WriteLine(); 
Multipliction_Array(array1,array2);