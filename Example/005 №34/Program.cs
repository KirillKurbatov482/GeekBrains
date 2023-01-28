// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




int[] randomArray (int length){

    int [] array = new int [length];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int nextNumber(int[] array) {
    int countNumber = 0;

    for (int i=0; i < array.Length; i++)
        if (array[i]%2 == 0)
            countNumber++;

    return countNumber;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write("\n");
}


int [] array = randomArray(5);
showArray(array);
Console.WriteLine(nextNumber(array));


