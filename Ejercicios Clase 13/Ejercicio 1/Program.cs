/* 
Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
*/

using Ejercicio_1.Modelo;

var billetera1 = new Billetera()
{
    BilletesDe10 = 2,
    BilletesDe20 = 3,
    BilletesDe50 = 10,
    BilletesDe100 = 7,
    BilletesDe200 = 5,
    BilletesDe500 = 3,
    BilletesDe1000 = 5
};


Console.WriteLine(billetera1.Total());


var billetera2 = new Billetera()
{
    BilletesDe10 = 4,
    BilletesDe20 = 8,
    BilletesDe50 = 1,
    BilletesDe100 = 2,
    BilletesDe200 = 3,
    BilletesDe500 = 5,
    BilletesDe1000 = 10
};

Console.WriteLine(billetera2.Total());


var billetera3 = new Billetera();

billetera3 = billetera1.Combinar(billetera2);


Console.WriteLine(billetera1.Total());
Console.WriteLine(billetera2.Total());

Console.WriteLine("BILLETERA 3");
Console.WriteLine(billetera3.Total());


