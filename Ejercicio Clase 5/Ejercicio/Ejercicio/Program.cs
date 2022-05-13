Console.Clear();

Console.WriteLine("Porfavor ingrese su nombre");

string nombre = Console.ReadLine();

Console.WriteLine("¡Hola " + nombre + "!");

Console.WriteLine("¿Desea continuar? Ingrese 'S' para una respuesta afirmativa o 'N' para una negativa");

string continuar = Console.ReadLine();

if (continuar.ToUpper() == "S")
 {
        Console.WriteLine("1232");
 }
else if (continuar.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamete");
}
else
{
    Console.WriteLine("Opcion no valida");
}
    
Console.ReadKey();
