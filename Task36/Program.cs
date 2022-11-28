// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int InputInt(string letter){

    Console.Write($"Enter {letter}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetFillArray(int size){

    int[] arr = new int[size];

    for (int i=0; i < arr.Length; i++) arr[i] = new Random().Next(-100,101);
    
    return arr;
}

void PrintArray(int[] arr){

    Console.WriteLine(string.Join(", ", arr));
}

int GetSummOddFromArray(int[] arr){

    int summ = 0;
    
    for(int i=0; i < arr.Length; i++) if(i%2 == 1) summ+= arr[i];
    
    return summ;
}

Console.Clear();
int a = InputInt("Size");
int[] arr = GetFillArray(a);

PrintArray(arr);
Console.WriteLine(GetSummOddFromArray(arr));