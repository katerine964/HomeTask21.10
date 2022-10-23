// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}
void Mean(double [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double s=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            s=s+matrix[i,j];
            
        }
        double mean=s/matrix.GetLength(0);
        Console.Write($"{mean}\t");
    }
    
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [n, m];
InputMatrix(matrix);
Console.WriteLine("Средние арифмитические столбцов:");
Mean(matrix);
Console.WriteLine();
