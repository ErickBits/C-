Console.WriteLine("Hello, World!");

string telf = "123-456-7890";
string col = "blue";
int edad = 30;
float altura = 1.75f;
bool esEstudiante = true;

//Array
// Esta lista ocupa un espacio en memoria que no se puede cambiar
int[] numeros = { 1, 2, 3, 4, 5 };
Console.WriteLine("Numeros: {0}", numeros[0]);

Console.WriteLine("Telefono: {0}", telf);

//LIsta
// Esta lista puede cambiar de tamaño por que es dinamica
List<int> numeros2 = new List<int> { 23, 45, 16, 37, 3, 99, 22};
Console.WriteLine(numeros2[0]);
Console.WriteLine(string.Join(",",numeros2));

Dictionary<int, string> jugadores = new Dictionary<int, string>();
jugadores.Add(10, "Messi");
jugadores.Add(7, "Cristiano");
jugadores.Add(9, "Lewandowski");

Console.WriteLine(jugadores[10]);

//Constantes

const float pi = 3.1416f;

Console.WriteLine(4 == 4);
Console.WriteLine(4 != 4);
Console.WriteLine(4 > 4);
Console.WriteLine(4 <= 4);

Console.WriteLine(true && true);
Console.WriteLine(true || false);
Console.WriteLine(!true);

bool autorizado = true;

if (autorizado)
{
    Console.WriteLine("Usuario autorizado");
}
else
{
    Console.WriteLine("Usuario no autorizado");
}

int entero = 100;

if (entero == 99)
{
    Console.WriteLine("El numero es 99");
}
else if (entero == 100)
{
    Console.WriteLine("El numero es 100");
}
else
{
    Console.WriteLine("El numero no es ni 99 ni 100");
}

string color = "rojo";

switch (color)
{
    case "rojo":
        Console.WriteLine("El color es rojo");
        break;
    case "azul":
        Console.WriteLine("El color es azul");
        break;
    default:
        Console.WriteLine("El color no es ni rojo ni azul");
        break;
}

int sumar(int primero, int segundo)
{
    return primero + segundo;
}

Console.WriteLine(sumar(3,4));

//La diferencia entre void y una funcion normal, es que void no devuelve ningun dato mientras que las otras si

string[] animales = { "perro", "gato", "conejo", "loro" };

foreach (string animal in animales)
{
    Console.WriteLine(animal);
}

void multiplicador(int primero, int segundo)
{
    Console.WriteLine(primero * segundo);
}

int[] numer = { 1, 2, 3, 4, 5 };

foreach (int num in numer)
{
    multiplicador(num, 3);
}

int ent = 100;
int emergencia = 103;

while (ent <= emergencia)
{
    Console.WriteLine(ent);
    ent++;
}

Lenguaje javascript = new Lenguaje("JavaScript", 1995);
javascript.descripcion();