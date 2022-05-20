Console.Clear();

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroingresado, contador = 0;

do
{
    Console.Clear();
    contador++;
    Console.WriteLine("Ingrese un numero");
numeroingresado = int.Parse(Console.ReadLine());
    if (numeroingresado > numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es demasiado grande, vuelva a intentarlo");
        Console.ReadKey();
    }
    else if (numeroingresado < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es demasiado chico, vuelva a intentarlo");
        Console.ReadKey();
    }

} while (numeroingresado != numeroSecreto);

Console.WriteLine("Su numero coincide con el obtenido al azar, FELICITACIONES!");
Console.ReadKey();







