using MyChessProj;

PrintMatrixMainDiagonal(8);

PrintMatrixAuxiliaryDiagonal(5);

MyPointer p1 = new MyPointer(1, 3);
MyPointer p2 = new MyPointer(1, 6);
Console.WriteLine(CheckTheRook(p1, p2));

MyPointer p3 = new MyPointer(1, 3);
MyPointer p4 = new MyPointer(1, 6);
Console.WriteLine(CheckTheKnight(p3, p4));

void PrintMatrixMainDiagonal(int matrixSize)
{
	char[,] matrix = new char[matrixSize, matrixSize];
	for (int i = 0; i < matrixSize; i++)
	{
		for (int j = 0;	j< matrixSize; j++)
		{
            if (i == j)
                matrix[i, j] = '#';
            else
                matrix[i, j] = '*';
            Console.Write(matrix[i, j].ToString() + '\t');
        }
        Console.WriteLine();
	}
    char[] newarr = new char[matrixSize];
	for (int i = 0; i < matrixSize; i++)
	{
		newarr[i] = matrix[i,i];
	}
    Console.WriteLine(newarr);
}


void PrintMatrixAuxiliaryDiagonal(int matrixSize)
{
    char[,] matrix = new char[matrixSize, matrixSize];
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            if (i + j == matrixSize - 1)
                matrix[i, j] = '#';
            else
                matrix[i, j] = '*';
            Console.Write(matrix[i, j].ToString() + '\t');
        }
        Console.WriteLine();
    }
    char[] newarr = new char[matrixSize];
    for (int i = 0; i < matrixSize; i++)
    {
        for(int j = 0;j < matrixSize; j++)
        {
            if (i+j==matrixSize-1)
            {
                newarr[i]=matrix[i,j];
            }
        }
    }
    Console.WriteLine(newarr);
}

bool CheckTheRook(MyPointer p1, MyPointer p2)
{
    if (p1.x == p2.x || p1.y == p2.y)
        return true;
    return false;
}

bool CheckTheKnight(MyPointer p1, MyPointer p2)
{
    int a = Math.Abs(p1.x - p2.x);
    int b = Math.Abs(p1.y - p2.y);
    if ((a==2 && b==1) || (a==1 && b==2))
        return true;
    return false;
}


int[,] CreateMatrix(int matrixSize)
{
    int[,] matrix = new int [matrixSize, matrixSize];
    for     (int i = 0;i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            matrix[i, j] = -1;
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(matrix[i,j].ToString() + '\t');
        }
        Console.WriteLine();
    }
    
}

void FillTheNumbers(int[,] matrix, int x, int y, int value)
{
    try
    {
        matrix[x - 2, y - 1] = value;
        matrix[x + 2, y - 1] = value;
        matrix[x - 2, y + 1] = value;
        matrix[x + 2, y + 1] = value;

        matrix[x - 1, y - 2] = value;
        matrix[x + 1, y - 2] = value;
        matrix[x - 1, y + 2] = value;
        matrix[x + 1, y + 2] = value;
        printMatrix(matrix);
    }
    catch (IndexOutOfRangeException) { }
    

    

}

void CountTheSteps(MyPointer p1, MyPointer p2)
{
    
    int count = 2;
    int[,] matrix = CreateMatrix(8);
    matrix[p1.x - 1, p1.y - 1] = 0;
    printMatrix(matrix);
    FillTheNumbers(matrix, p1.x, p1.y, 1);

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (matrix[i, j] > 0)
            {
                continue;
            }
            FillTheNumbers(matrix, i, j, count);
            count++;
        }
    }

    //return count;
}
MyPointer p5 = new MyPointer(4, 2);
MyPointer p6 = new MyPointer(5, 7);
CountTheSteps(p5, p6);