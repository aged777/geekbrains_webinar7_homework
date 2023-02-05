// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// 1.   Функция проверки, что задано число
// 2.   Функция создания двумерного массива, заполненного целыми числами
// 3.   Функция вывода в консоль двумерного массива типа int
// 4.   Функция поиска элемента по индексу, возвращает значение элемента, либо указание, что элемента нет
// 5.   Демонстрация работы с выводом в консоль

// 1.   Функция получения числа от пользователя с проверкой, что задано число
int getNumberFromUserWithCheck() {
    int result = 0;
    bool ifNumber = false;

    while(!ifNumber) {
        System.Console.WriteLine("Введите число: ");
        int.TryParse(Console.ReadLine(), out result);
        ifNumber = true;
    }

    return result;
}

// 2.   Функция создания двумерного массива, заполненного целыми числами
int[,] GenerateIntTwoDimArray(int mRows, int nColumns) {
    int[,] array = new int[mRows, nColumns];
    Random tmp = new Random();
    for(int i = 0; i < mRows; i ++) {
        for(int j = 0; j < nColumns; j++) {
            array[i, j] = tmp.Next(1, 9);      // такой интервал - из примера
        }
    }
    return array;
}

// 3.   Функция вывода в консоль двумерного массива типа int
void PrintIntTwoDimArray(int[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        System.Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine("]");
    }
}

// 4.   Функция поиска элемента по индексу, возвращает значение элемента, либо указание, что элемента нет
void FindElementOrPrintAbsent(int[,] array, int M, int N){
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            if(i == M && j == N) {
                System.Console.WriteLine($"позиция элемента: [{i},{j}]");
                System.Console.WriteLine($"значение элемента: {array[i,j]}");
                return;
            }
        }
    }
    System.Console.WriteLine("Такого числа в массиве нет.");
}

// 5.   Демонстрация работы с выводом в консоль
System.Console.WriteLine("Программа создаёт двумерный массив с размерами M x N, введёнными " + 
                         "пользователем и заполняет его случайными целыми числами." +
                         " Затем программа найдет элемент по его позиции, либо сообщит, " +
                         "что такого элемента нет.");
System.Console.Write("Введите размер M:  ");
int mRows = getNumberFromUserWithCheck();
System.Console.Write("Введите размер N:  ");
int nColumns = getNumberFromUserWithCheck();
int[,] array = GenerateIntTwoDimArray(mRows, nColumns);
System.Console.WriteLine($"Создан массив: {mRows} строк, {nColumns} столбцов");
PrintIntTwoDimArray(array);

System.Console.Write("Введите позицию элемента M:  ");
int M = getNumberFromUserWithCheck();
System.Console.Write("Введите позицию элемента N:  ");
int N = getNumberFromUserWithCheck();
FindElementOrPrintAbsent(array, M, N);



