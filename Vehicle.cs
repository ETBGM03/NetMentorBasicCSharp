
/***
 * Las propiedades de una clase van en CamelCase y las del contructor en lowerCase
 */

/***
 * Tenemos 4 modificadores de acceso 
 * public -> No tiene limitaciones de acceso
 * private -> Solo se puede acceder en la misma clase
 * internal -> Solo se puede acceder en el mismo proyecto (en caso que hayan 2+ referenciando a root)
 * protected -> Solo es accesible desde la clase que se genera y sus clases derivadas
 * 
 * namespace -> Sirve para organizar las clases, dado que podemos tener varias clases con el mismo nombre pero en diferentes namespace y para
   referenciar a uno u otro usamos el using namespace
 */

/***
 * Tipos primitivos
 * Números Enteros -> byte, short, int, long
 * Número Reales -> float, double, decimal
 * Caracteres -> char
 * Booleanos -> bool
 */

/***
 * Tipos no primitivos
 * Clases -> Sirve como modelo para crear objectos
 * Structs -> 
 * Enum -> Sirve hacer enumeraciones (enumerar los dias de la semana, el cual NUNCA van a cambiar)
 * Array -> Sirve para almacenar lista de elementos y accedemos mediante el indice
 * String -> Permite concatenar una serie de caracteres
 * DateTime -> Permite 
*/

/***
 * Operadores Lógicos
 * &&, ||, !
 * */

namespace BasicNetMentor
{
    internal class Vehicle
    {
        public decimal MaxVelocity {  get; set; }
        public decimal ConsumptionPerKm { get; set; }

        public Vehicle(decimal velocity, decimal consume)
        {
            MaxVelocity = velocity;
            ConsumptionPerKm = consume;
        }
        /// <summary>
        /// Calcula el consumo total
        /// </summary>
        /// <param name="totalKm">
        /// Distancia recorrida en km
        /// </param>
        /// <returns>
        /// Valor en decimal del consumo litro de gasolina
        /// </returns>
        public decimal TotalConsume(decimal totalKm)
        {
            return ConsumptionPerKm * totalKm;
        }
    }
}
