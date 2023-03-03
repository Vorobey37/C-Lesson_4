/*
*/
Console.Clear();
string[,] table = new string[2, 5];

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        table[rows, columns] = "а";
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine();
}

int[,] matrix = new int[3, 4];
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}
PrintMatrix(matrix);
FillMatrix(matrix);
PrintMatrix(matrix);