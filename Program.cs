Console.WriteLine("Dois Numeros: ");
string[] valuesLC = Console.ReadLine().Split(' ');
int L = int.Parse(valuesLC[0]);
int C = int.Parse(valuesLC[1]);

int[,] mat = new int[L, C];

for (int i = 0; i < L; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < C; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.Write("Numero para encontrar: ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < L; i++)
{
    for (int j = 0; j < C; j++)
    {
        if (mat[i, j] == N)
        {
            Console.WriteLine("Posição: {0}, {1}", i, j);
            if (j > 0)
            {
                Console.WriteLine("Left {0}", mat[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Up {0}", mat[i - 1, j]);
            }
            if (j < C - 1)
            {
                Console.WriteLine("Right {0}", mat[i, j + 1]);
            }
            if (i < L - 1)
            {
                Console.WriteLine("Down {0}", mat[i + 1, j]);
            }
        }
    }
}


