/*
Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
*/

int[] numeros = new int[10];

Console.WriteLine("Ingrese 10 numeros:");
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

double suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

int menor = int.MaxValue;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

int mayor = int.MinValue;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
}

double promedio;
promedio = suma / numeros.Length;

Console.WriteLine("Los numeros ingresados son:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"{numeros[i]} ");
}

Console.WriteLine();
Console.WriteLine($"La suma de los numeros ingresados es: {suma}");
Console.WriteLine($"El mayor numero ingresado es: {mayor}");
Console.WriteLine($"El menor numero ingresado es: {menor}");
Console.WriteLine($"El promedio de todos los numereros ingresados es: {promedio}");