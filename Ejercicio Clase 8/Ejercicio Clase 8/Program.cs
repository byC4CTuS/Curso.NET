/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
 */

Console.WriteLine("Ingrese la cantidad de filas de la matriz");
int fila = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas");
int columna = int.Parse(Console.ReadLine());

int[,] numeros = new int[fila, columna];

Console.WriteLine("A continuacion ingrese los valores de la matriz:");
Console.WriteLine();
double suma = 0;
double[] promedios = new double[columna]; 

for (int i = 0; i < numeros.GetLength(0); i++)
{
    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        Console.WriteLine("Posicion [" + (i+1) + "," + (j+1) + "]");
        numeros[i, j] = int.Parse(Console.ReadLine());
    }
}


Console.WriteLine("-----------------------------------------");
Console.WriteLine("A continuacion se mostrara su matriz:");
Console.WriteLine("-----------------------------------------");

for (int i = 0; i < numeros.GetLength(0); i++)
{
    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        Console.Write($"{numeros[i, j]} ");
    }
    Console.WriteLine();
}


for (int j = 0; j < numeros.GetLength(1); j++)
{
    for (int i = 0; i < numeros.GetLength(0); i++)
    {
        suma += numeros[i, j];
    }

    promedios[j] = suma / fila;
    suma = 0;
}

Console.WriteLine();

for (int j = 0; j < columna; j++)
{
    Console.WriteLine($"El promedio de la columna {j+1} es: {promedios[j]}");
}