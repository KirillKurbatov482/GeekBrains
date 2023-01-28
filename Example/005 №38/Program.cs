// // Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// // // [3 7 22 2 78] -> 76

int[] RandomArray (int number){

    int [] array = new int [number];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(0, 100);
    }

    return array;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write("\n");
}

int [] array = RandomArray(5);
showArray(array);
Console.WriteLine($"Разница между max and min = {array.Max() - array.Min()}");