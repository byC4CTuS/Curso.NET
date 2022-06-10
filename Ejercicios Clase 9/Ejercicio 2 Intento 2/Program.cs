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
int[,] pos = new int[3, 5];
int cont = 0;
int aux = 0;

do
{
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        while (true)
        {
            cont = 0;
            pos[i,j] = numeros.Next(0, 9);
                for (int k = 0; k < j; k++)
                {
                    if (pos[i,j] == pos[i,k])
                    {
                    cont++;
                    }
                }
            if (cont == 0)
            {
                break;
            }
        }
    }
}

cont = 0;

for (int num = 0 ; num < 9; num++)
{
    aux = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (pos[i,j] == num)
            {
                aux++;
            }
        }
    }
    if (aux == 0 || aux == 3)
    {
    cont++;
    }
}

    Console.WriteLine();
    Console.WriteLine();

    for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(pos[i,j] + " ");
    }
    Console.WriteLine();
}

}
while (cont != 0);


for (int i = 0; i < pos.GetLength(0); i++)
{
    for (int j = 0; j < pos.GetLength(1); j++)
    {
        while (true)
        {
            cont = 0;
            bingo[i, pos[i, j]] = numeros.Next(0 + (10 * pos[i, j]), 10 + (10 * pos[i, j]));
            for (int k = 0; k < i; k++)
            {
                if (bingo[i, pos[i, j]] == bingo[k, pos[i, j]] || bingo[i, pos[i, j]] == 0)
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                break;
            }
        }
    }
}

//while (true)
//{
//    cont = 0;
//    bingo[i, pos[i, j]] = numeros.Next(1 + (10 * pos[i, j]), 10 + (10 * pos[i, j]));
//    for (int k = 0; k < i; k++)
//    {
//        if (pos[i, j] == pos[k, j])
//        {
//            cont++;
//        }
//    }
//    if (cont == 0)
//    {
//        break;
//    }
//}



Console.WriteLine();
Console.WriteLine("---------------------------------------------");
for (int i = 0; i < bingo.GetLength(0); i++)
{
    for (int j = 0; j < bingo.GetLength(1); j++)
    {

        if (bingo[i, j] == 0)
        {
            Console.Write($"    |");
        }
        else if (bingo[i, j] > 0 && bingo[i, j] < 10)
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
