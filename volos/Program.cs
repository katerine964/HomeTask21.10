// See https://aka.ms/new-console-template for more information
 
void Arr(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write ("Стоимость волос в день номер "+(i+1)+": ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    Console.WriteLine($"Расценки по дням: [{string.Join(", ", array)}]");
}
int Func(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        int max = array[i];
        for (int j = i+1; j < array.Length; j++)        
        {
            if (array[j]>max)
            max=array[j];
        }
        sum=sum+max;
    }
    return sum;
}
int Func2(int [] array)
{
    int max=array[array.Length-1];
    int sum=0;
    for( int i=array.Length-1; i>=0; i--)
    {
        if(array[i]>=max)
           max=array[i];
        sum=sum+max;
    }
    return sum;
}
Console.Clear(); 
Console.Write("Введите кол-во дней: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n];
Arr(array);
//Console.WriteLine("Наибольшая выручка от продажи волос: "+Func(array));
Console.WriteLine("Наибольшая выручка от продажи волос: "+Func2(array));