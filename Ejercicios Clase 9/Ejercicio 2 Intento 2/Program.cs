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

int[,] bingo = new int[3, 9];                       // Matriz pal bingo
int[,] pos = new int[3, 5];                         // Matriz de posiciciones  
int cont = 0;
int aux = 0;

do                                                  // Llenado de la matriz pos, solo necesito generar las posicion j
{                                                   // porque utilizo la i (filas) de la matriz pos para llenar bingo
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            while (true)
            {
                cont = 0;
                pos[i,j] = numeros.Next(0, 9);          // Genero las posiciones j para el bingo
                for (int k = 0; k < j; k++)             // Comprobacion de que no se genere una posicion repetida
                {
                    if (pos[i,j] == pos[i,k])           // Si el numero generado es igual a otro anterior en la misma fila --> cont++
                    {
                    cont++;
                    }
                }
                if (cont == 0)                          // Si el contador es 0 es que no se repite el numero generado
                {                                       // Si es distinto de 0 vuelve a generar y comprobar el numero
                break;
                }
            }
        }
    }


    cont = 0;

    for (int num = 0 ; num < 9; num++)                  // Recorro toda la matriz pos contando la cantidad de veces que se
    {                                                   // repite cada posicion 0 - 8
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
        if (aux == 0 || aux == 3)                       // Si la pos se repite 3 veces o ninguna --> cont++
        {
        cont++;                                         // Si el cont es != 0 es que una columna de la matriz bingo esta o llena o vacia
        }                                               // por lo que no cumplira la condicion de 1 o 2 numeros por columna y regenerara 
    }                                                   // la matriz pos

    Console.WriteLine();
    Console.WriteLine();

    for (int i = 0; i < 3; i++)                         // Recorro la matriz pos para verla en pantalla, mas debug visual que otra cosa.
    {   
        for (int j = 0; j < 5; j++)
        {
            Console.Write(pos[i,j] + " ");
        }
        Console.WriteLine();
    }

} while (cont != 0);                                    // Cierre del while que explique arriba


for (int i = 0; i < 3; i++)                                                                     // Recorro la matriz pos 
{
    for (int j = 0; j < 5; j++)
    {
        while (true)
        {
            cont = 0;                                                                           // Para cada valor en pos, tomo su i y utilizo el valor como j, [i del valor, j --> valor]
            bingo[i, pos[i, j]] = numeros.Next(0 + (10 * pos[i, j]), 10 + (10 * pos[i, j]));    // y en esa posicion que obtengo, genero un numero teniendo en cuenta su columna (el valor).
            for (int k = 0; k < i; k++)                                                         // Con este for compruebo que no se repita el numero que genero con otro en su columna.
            {
                if (bingo[i, pos[i, j]] == bingo[k, pos[i, j]] || bingo[i, pos[i, j]] == 0)     // Ademas no dejo que se genere el 0 por cosas xd
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


Console.WriteLine();
Console.WriteLine("---------------------------------------------");
Console.WriteLine();

for (int i = 0; i < 3; i++)                                     // Coso para mostrar el bingo y que no sea nefasto
{
    for (int j = 0; j < 9; j++)
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
