// /Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] randomArray (int length){

    int [] array = new int [length];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(-99, 100);
    }

    return array;
}

int sumNumber(int[] array) {
    int sum = 0;

    for (int i=1; i < array.Length; i+=2)
        sum += array[i];

    return sum;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write("\n");
}


int [] array = randomArray(5);
showArray(array);
Console.WriteLine(sumNumber(array));