
/*Console.Write("Escribe un numero y mira la magia: ");

string input = Console.ReadLine();

int numInput = int.Parse(input);

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{numInput} * {i}: {i* numInput}");
} */

/*Console.Write("Escribe tu edad: ");
string input = Console.ReadLine();

int inputNumber = int.Parse(input);

int currentYear = DateTime.Now.Year;

Console.WriteLine($"Naciste en el año: {currentYear - inputNumber*/

/***
Console.Write("Escribe edad hijo: ");
string inputHijo = Console.ReadLine();

Console.Write("Escribe edad padre: ");
string inputPadre = Console.ReadLine();

int inputNumberHijo = int.Parse(inputHijo);
int inputNumberPadre = int.Parse(inputPadre);

Console.WriteLine($"La edad del padre es {inputNumberPadre} y 
la del hijo es {inputNumberHijo} lo que significa que hay una diferencia de {inputNumberPadre - inputNumberHijo}"); **/

// CONDICIONALES
/***
 *  if estructurados son los de toda la vida
 *  if ternario if condicion ? true : false
 *  
 *  swicth -> entra en el case en base a la condicion
 **/


// BUCLES
/***
 * for ->  for(int i = 0; i < 10; i++)
 * while -> while (iterator <= 10) Se ejecutará mientras sea válida la condicion.
 * do while -> 
 
 */

/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

int iterator = 0;

while (iterator <= 10)
{
    Console.WriteLine(iterator);
    iterator++;
} 


int iterator = 0;

do
{
    Console.WriteLine(iterator);
    iterator++;
} while (iterator == 0); */

//MODO DEBUG -> Para ello el modo de compilado debe estar en 'debug' y necesitamos agregar breakpoints



/*int iterator = 0;

do
{
    var print = new ExampleClase();

    print.PrinIterator(iterator);
    iterator++;
} while (iterator <= 10);*/

/**
Console.Write("Escribe tu nombre: ");
var name = Console.ReadLine();

if(name == "Esteban")
{
    Console.WriteLine("Hurra Esteban");
}

switch (name)
{
    case "Esteban":
        Console.WriteLine("Estrban");
        break;
    case "Tomas": 
        Console.WriteLine("Tomas");
        break;
}*//**
Console.Write("Escribe tu nombre: ");
var name = Console.ReadLine();

if(name == "Esteban")
{
    Console.WriteLine("Hurra Esteban");
}

switch (name)
{
    case "Esteban":
        Console.WriteLine("Estrban");
        break;
    case "Tomas": 
        Console.WriteLine("Tomas");
        break;
}*/


//Trabajar con caracteres

/***
 * char -> Representan un bite en memoria por lo que solo se guarda una letra, y debe ser en comillas simples. Ya que si ponemos "" lo convierte a string o da un error el compilador.
 * stringBuilder -> es igual a string pero es mutable, lo que reduce el espacio en memoria. string cuando concatenamos a otro string lo que hace el compiler es crear otro espacio en memoria para esa nueva string, con stringbuild es 1 solo. (using System.Text;)
 **/

/*
char a = 'H';   

string myString = "hello my name is Esteban";


Console.WriteLine(myString.ToLower());  //convert string to lowercase  
Console.WriteLine(myString.ToUpper());  //convert string to UPPERCASE   
Console.WriteLine(myString.Equals("Hello"));  //compare the strings and return true or false
Console.WriteLine(myString.IndexOf("llo"));  //return the first position of character
Console.WriteLine(myString.Contains("hello"));  //return boolean if the sentence is in string

StringBuilder sb = new StringBuilder("example ");
sb.Append(myString);

Console.WriteLine(sb); */


// ARRAYS
// Nos permite almacenar una coleccion de datos, no tenemos limite de tamañan (más que la memoria misma del ordenador) y son INMUTABLES
// int[] arrInt = new int[5]
