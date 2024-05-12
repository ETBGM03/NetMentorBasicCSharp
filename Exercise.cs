namespace BasicNetMentor
{
    public class Exercise
    {
        public void ExerciseOne()
        {
            //Entrar por teclado 2 numeros y mostrar por pantalla todos los pares
            Console.Write("Escribe un numero: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe un segundo numero: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            for (int i = numberOne; i < numberTwo; i++)
            {
                var module = i % 2;
                if(module == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ExerciseTwo()
        {

            //Escribe un programa que imprima los numeros perfectos entre 1 y n (1+2+3) = 6
            Console.Write("Escribe un numero: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < numberOne; i++)
            {
                var aux = 0;

                for (int j = 1; j < i; j++)
                {
                   if (i%j == 0)
                    {
                        aux += j;
                    }
                }
                if(i == aux)
                {
                    Console.WriteLine($"el numero {i} es perfecto");
                }

            }

        }

        public void ExerciseThree()
        {
            //Preguntar por teclado por un nombre y repetir hasta que ponga "NetMentor"
            
            string aux;
            string target = "zoe";

            do
            {
                Console.Write("Escribe un nombre: ");
                string input = Console.ReadLine();
                aux = input!;

                if(aux == target)

                {
                    Console.WriteLine("Ganaste, te queremos!! HAHAHA");
                } else
                {
                    Console.WriteLine("Sigue intentando");
                }
            }
            while (aux != target);
        }
    }
}
