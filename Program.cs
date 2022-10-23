// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(float [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next();
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
float [,] matrix = new float[n, m];
InputMatrix(matrix);