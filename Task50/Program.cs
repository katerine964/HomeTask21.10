// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(int[,] matrix)
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
void FindEl (int [ , ] matrix, int a, int b)
{
    if(a>matrix.GetLength(0)||a<1||b>matrix.GetLength(1)||b<1)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
       Console.WriteLine("Искомый элемент: "+matrix[a-1,b-1]); 
    } 
    
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.Write("Введите номер строки, в которой находится элемент: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца, в котором находится элемент: ");
int b = Convert.ToInt32(Console.ReadLine());
FindEl(matrix, a, b);