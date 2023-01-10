/*
int n = 5;
int[] array = new int [n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
//[4,3,5,2,1] - наш массив
//0(n) - скорость работы алгоритма от 0 до n
//[1,2,3,4,5] - наш отсортированный массив, 0(n*log n) - быстрая скорость нахлждения массива
//((5+1/2)*5) - нахождение суммы всх элементов массива арифмитическим способом
// Но n<n*log n
int summa = 0;
for (int i = 0; i < n; i++)
{
    summa += array[i];
}
Console.WriteLine(summa);
//0(n)-
*/

//Вывести таблицу умножения от 1 до 5:
/* 1 2 3 4 5
1  1 2 3 4 5
2  2 4 6 8 10
3  3 6 9 12 15
4  4 8 12 16 20
5  5 10 15 20 25
*/

/*
//Первый способ обычный
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= n; j++)
    {
        Console.Write(i*j);
        Console.Write("\t");
    }
    Console.WriteLine();
}
*/

//Второй способ через матрицу или двумерный массив(быстрее)
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[n,n];
for (int i = 0; i < n; i++)               //заполнение ведется * * * ---
                                                             //* * * | -- 
                                                             //* * * | |   и т.д.
{
    for (int j = i; j < n; j++)
    {
      
        matrix[i,j] = (i+1)*(j+1);
        matrix[j,i] = (i+1)*(j+1);
    }
     Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i,j]);
        Console.Write("");
    }
}
//0(n^2)