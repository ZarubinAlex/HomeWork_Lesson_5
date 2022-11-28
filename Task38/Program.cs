// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int InputInt(string letter){

    Console.Write($"Enter {letter}: ");
    return int.Parse(Console.ReadLine());
}

int GetNegative(){

    int a=1;
    if(new Random().Next(0,2) == 1) a = -1;
    return a;
}

double[] GetFillArrayDouble(int size){

    double[] arr = new double[size];
    for (int i=0; i < arr.Length; i++){

        arr[i] = Math.Round(new Random().NextDouble() * 100, 1) * GetNegative();
    }
    
    return arr;
}

double DiffMaxMin(double[] arr){

    double max = arr[0];
    double min = arr[0];

    for(int i=1; i < arr.Length; i++){

        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    
    System.Console.WriteLine($"Max = {max}, Min = {min}");
    return Math.Round(max - min, 1);
}

void PrintArray(double[] arr){

    Console.WriteLine(string.Join("; ", arr));
}


Console.Clear();
int a = InputInt("Size");
double[] arr = GetFillArrayDouble(a);

PrintArray(arr);
Console.WriteLine($"Разница: {DiffMaxMin(arr)}");
Console.WriteLine();