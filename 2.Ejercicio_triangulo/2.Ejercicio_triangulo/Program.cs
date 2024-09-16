public class Program
{
    private static void Main(string[] args)
    {
        //Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        //Declaracion de los inputs
        double seg1, seg2, seg3;
        bool Istriangle;
        string msj;

        //Pedir los datos - Input
        Console.Write("Ingrese el primer segmento:");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el primer segmento:");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el primer segmento:");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Proceso - Validacion
        //Validacion en cascada
        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    Istriangle = true;
                }
                else
                {
                    Istriangle = false;
                }
            }
            else
            {
                Istriangle = false;
            }
        }
        else
        {
            Istriangle = false;
        }

        //Validacion en una sola linea 
        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg2 + seg3) > seg1))
        {
            Istriangle = true;
        }
        else
        {
            Istriangle = false;
        }

        //Mostar mensaje - Output
        if (!Istriangle)
        {
            Console.Write("No se puede construir el triangulo");
        }
        else
        {
            Console.Write("Se puede construir el triangulo");
        }
    }
}
