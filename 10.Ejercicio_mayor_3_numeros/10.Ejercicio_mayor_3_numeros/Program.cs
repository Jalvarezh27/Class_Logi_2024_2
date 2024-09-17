using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados
        //Declaracion de las 3 variables - Inputs

        double n1, n2, n3;

        string msj;

        //Se piden datos :
        Console.Write("Ingrese el primer numero:");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero:");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer numero:");
        n3 = Convert.ToDouble(Console.ReadLine());

        //Validacion datos

        if (n3 > n1 && n3 > n2)
        {
            Console.WriteLine($"El Numero {n3} es el mayor");
            if (n2 > n1)
            {
                Console.WriteLine($"El Numero {n2} es el del medio");
                Console.WriteLine($"El Numero {n1} es el menor");
            }
            else
            {
                Console.WriteLine($"El Numero {n1} es el del medio");
                Console.WriteLine($"El Numero {n2} es el menor");
            }

        }
        else (n2 > n1 && n2 > n3) 
        {
            Console.WriteLine($"El Numero {n2} es el mayor");
            if (n1 > n3)
            {
                Console.WriteLine($"El Numero {n1} es el del medio");
                Console.WriteLine($"El Numero {n3} es el menor");
            }
            else
            {
                Console.WriteLine($"El Numero {n3} es el del medio");
                Console.WriteLine($"El Numero {n1} es el menor");
            }

        }
        else if (n1 > n2 && n1 > n3) 
        { 
            Console.WriteLine($"El numero {n1} es el mayor");
            if (n2 > n3)
            {
                Console.WriteLine($"El Numero {n2} es el del medio");
                Console.WriteLine($"El Numero {n3} es el menor");
            }
            else
            {
                Console.WriteLine($"El Numero {n3} es el del medio");
                Console.WriteLine($"El Numero {n2} es el menor");
            }
        }
    }
}