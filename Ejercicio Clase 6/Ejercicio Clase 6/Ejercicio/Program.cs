Console.Clear();

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroingresado, contador = 0;
Console.WriteLine("Se generara un numero aleatorio entre 1 y 20, usted debe adivinarlo.");
do
{
    contador++;
    Console.WriteLine("Ingrese un numero");
numeroingresado = int.Parse(Console.ReadLine());
    if (numeroingresado > numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es demasiado grande, vuelva a intentarlo");
    }
    else if (numeroingresado < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es demasiado chico, vuelva a intentarlo");
    }

} while (numeroingresado != numeroSecreto);

Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
Console.WriteLine($"Lo has logrado en {contador} intentos!!"); 

Console.ReadKey();







