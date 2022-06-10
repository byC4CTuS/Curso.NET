/*
Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/

Random numeros = new Random();

int[,] bingo = new int[3, 9];
int[] pos0 = new int[5];
int[] pos1 = new int[5];
int[] pos2 = new int[5];
int cont = 0;

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        cont = 0;
        pos0[i] = numeros.Next(0, 9);
        for (int j = 0; j < i; j++)
        {
            if (pos0[i] == pos0[j])
            {
                cont++;
            }
        }
        if (cont == 0)
        {
            break;
        }
    }
    Console.Write(pos0[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        cont = 0;
        pos1[i] = numeros.Next(0, 9);
        for (int j = 0; j < i; j++)
        {
            if (pos1[i] == pos1[j])
            {
                cont++;
            }
        }
        if (cont == 0)
        {
            break;
        }
    }
    Console.Write(pos1[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        cont = 0;
        pos2[i] = numeros.Next(0, 9);
        for (int j = 0; j < i; j++)
        {
            if (pos2[i] == pos2[j])
            {
                cont++;
            }
        }
        if (cont == 0)
        {
            break;
        }
    }
    Console.Write(pos2[i] + " ");
}

for (int i = 0; i < bingo.GetLength(0); i++)
{
    for (int j = 0; j < bingo.GetLength(1); j++)
    {
        if (i == 0)
        {
            foreach (int k in pos0)
            {
                if (k == j)
                {
                    bingo[i, j] = numeros.Next(1 + (10 * j), 10 + (10 * j));
                }
            }
        }
        else if (i == 1)
        {
            foreach (int k in pos1)
            {
                if (k == j)
                {
                    bingo[i, j] = numeros.Next(1 + (10 * j), 10 + (10 * j));
                }
            }
        }
        else if (i == 2)
        {
            foreach (int k in pos2)
            {
                if (k == j)
                {
                    bingo[i, j] = numeros.Next(1+(10*j),10+(10 * j));
                }
            }
        }
    }
}





Console.WriteLine();
Console.WriteLine("---------------------------------------------");
for (int i = 0; i < bingo.GetLength(0); i++)
{
    for (int j = 0; j < bingo.GetLength(1); j++)
    {
        
        if (bingo[i, j] == 0)
        {
            Console.Write($"    |");
        }else if (bingo[i, j] > 0 && bingo[i,j] < 10)
        {
            Console.Write($" 0{bingo[i, j]} |");
        }
        else
        {
            Console.Write($" {bingo[i, j]} |");
        }
    }
    Console.WriteLine();
}
