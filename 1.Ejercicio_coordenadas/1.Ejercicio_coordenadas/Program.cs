internal class Program
{
    //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.
    private static void Main(string[] args)
    {
        //Datos de entrada
        //Declarar las variable
        double x1, x2, y1, y2, d;

        //Vamos a inicializar variables desde pantalla
        Console.Write("Por favor ingrese valor de x1:"); //Esta es la forma de escribir en pantalla
        x1 = Convert.ToDouble(Console.ReadLine()); //Esta es la forma de leer en pantalla

        Console.Write("Por favor ingrese valor de x2:");
        x2 = Convert.ToDouble(Console.ReadLine());     //Esta es la forma de escribir en pantalla

        Console.Write("Por favor ingrese valor de y1:");
        y1 = Convert.ToDouble(Console.ReadLine());    //Esta es la forma de escribir en pantalla

        Console.Write("Por favor ingrese valor de y2:");
        y2 = Convert.ToDouble(Console.ReadLine()); //Esta es la forma de escribir en pantalla

        //Proceso calculo de la variable "d"; 
        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y;

        //La clase math tiene muchos metodos, entre ellos l metodo sqrt, este señor recibe un parametro dentro de sus (), ese parametro es el numero que yo le mando al metodo para que me saque le raiz cuadrada!
        d = Math.Sqrt(suma);

        Console.WriteLine(" ");

        // Forma primitiva de concatenar texto a traves del simbolo " + "
        Console.WriteLine("Concatenar con +");
        Console.Write("La distancia entre los pares ordenados (" + x1 + "," + y1 + ") y (" + x2 + "," + y2 + " ) es: " + d);

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        //Forma de concatenar a traves del simbolo " $ " se llama interpolacion: 
        Console.WriteLine("Concatenar con el simbolo $");
        Console.Write($"La distancia entre los pares ordenados es ({x1},{y1}) y ({x2} , {y2}) es: {d}");

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        // Forma de  concatenar con la clase string.format:
        Console.WriteLine("Concatenar con string.format");
        Console.Write(string.Format("la distancia enttre los pares ordenados ({0} , {1}) y ({2} , {3}) es: {4}", x1, y1, x2, y2, d));
    }
}
