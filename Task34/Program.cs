// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int InputInt(string letter){

    Console.Write($"Enter {letter}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetFillArray(int size){

    int[] arr = new int[size];

    for (int i=0; i < arr.Length; i++) arr[i] = new Random().Next(100,1000);
    
    return arr;
}

void PrintArray(int[] arr){

    Console.WriteLine(string.Join(", ", arr));
}

int GetEvenFromArray(int[] arr){

    int count = 0;
    
    for(int i=0; i < arr.Length; i++) if(arr[i]%2 == 0) count++;
    
    return count;
}

Console.Clear();
int a = InputInt("Size");
int[] arr = GetFillArray(a);

PrintArray(arr);
Console.WriteLine(GetEvenFromArray(arr));