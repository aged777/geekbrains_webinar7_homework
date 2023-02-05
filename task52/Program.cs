// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// 1.   Функция проверки, что задано число
// 2.   Функция создания двумерного массива, заполненного целыми числами
// 3.   Функция вывода в консоль двумерного массива типа int
// 4.   Функция поиска среднего арифметического элементов в каждом столбце
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

// 4.   Функция поиска и вывода в консоль среднего арифметического элементов в каждом столбце
void FindAndPrintAverageInEachColumn(int[,] array){
    double[] result = new double[array.GetLength(1)];
    double tmp = 0;
    for(int i = 0; i < array.GetLength(1); i++) {
        for(int j = 0; j < array.GetLength(0); j++) {
            tmp += array[j,i];
        }
        result[i] = Math.Round(tmp / array.GetLength(0), 1);
        System.Console.Write(result[i] + "; ");
        tmp = 0;
    }
    System.Console.WriteLine("");
    
}

// 5.   Демонстрация работы с выводом в консоль
System.Console.WriteLine("Программа создаёт двумерный массив с размерами M x N, введёнными " + 
                         "пользователем и заполняет его случайными целыми числами." +
                         " Затем будет посчитано среднее арифметическое каждого столбца.");
System.Console.Write("Введите размер M:  ");
int mRows = getNumberFromUserWithCheck();
System.Console.Write("Введите размер N:  ");
int nColumns = getNumberFromUserWithCheck();
int[,] array = GenerateIntTwoDimArray(mRows, nColumns);
System.Console.WriteLine($"Создан массив: {mRows} строк, {nColumns} столбцов");
PrintIntTwoDimArray(array);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
FindAndPrintAverageInEachColumn(array);





