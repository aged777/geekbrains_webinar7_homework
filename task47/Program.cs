// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// 1.   Функция проверки, что задано число
// 2.   Функция создания двумерного массива, заполненного вещественными числами
// 3.   Функция вывода в консоль двумерного массива типа double
// 4.   Демонстрация работы с выводом в консоль

// 1. Функция получения числа от пользователя с проверкой, что задано число
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

// 2. Функция создания двумерного массива, заполненного вещественными числами
double[,] GenerateDoubleTwoDimArray(int mRows, int nColumns) {
    double[,] array = new double[mRows, nColumns];
    Random tmp = new Random();
    for(int i = 0; i < mRows; i++) {
        for(int j = 0; j < nColumns; j++) {
            array[i, j] = Math.Round(tmp.NextDouble() * 10, 1);
            if(tmp.Next(1, 3) > 1) array[i, j] = -1 * array[i, j];
        }
    }
    return array;
}

// 3. Функция вывода в консоль двумерного массива типа double
void PrintDoubleTwoDimArray(double[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        System.Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write(array[i, j]);          // сделал выравнивание вручную с if-ами поиграться
            if(array[i, j] % 1 == 0 && array[i, j] < 0) System.Console.Write("   ");    // не идеально
            else if(array[i, j] % 1 == 0 || array[i, j] >= 0) System.Console.Write("  ");
            else if(array[i, j] % 1 != 0 || array[i, j] >= 0) System.Console.Write(" ");
        }
        System.Console.WriteLine("]");
    }
}

// 4.   Демонстрация работы с выводом в консоль
System.Console.WriteLine("Программа создаёт двумерный массив с размерами M x N, введёнными " + 
                         "пользователем и заполняет его случайными вещественными числами.");
System.Console.Write("Введите размер M:  ");
int mRows = getNumberFromUserWithCheck();
System.Console.Write("Введите размер N:  ");
int nColumns = getNumberFromUserWithCheck();
double[,] array = GenerateDoubleTwoDimArray(mRows, nColumns);
System.Console.WriteLine($"Создан массив: {mRows} строк, {nColumns} столбцов");
PrintDoubleTwoDimArray(array);


