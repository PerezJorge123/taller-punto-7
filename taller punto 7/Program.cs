// 7.	Escribir un algoritmo que dados 2 valores de entrada imprima siempre
// la división del mayor entre el menor.

public class TallerPunto7
{
    static void Main(string[] args)
    {
        // datos de entrada: num1, num2, cociente
        // operacion: del cociente
        // salida: division del mayor entre el menor

        // declaro variables
        double num1, num2, cociente;

        // Pedir los numeros

        Console.Write("Ingresar el primer numero: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresar el segundo numero: ");
        num2 = double.Parse(Console.ReadLine());

        //Proceso (Calculo y validacion)

        if (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("La division es indeterminada.");
        }

        else if (num1 == 0)
        {
            cociente = num1 / num2;
            Console.WriteLine($"El resultado de la division es: {cociente}");
        }

        else if (num2 == 0)
        {
            cociente = num2 / num1;
            Console.WriteLine($"El resultado de la division es: {cociente}");
        }

        else if (num1 > num2)
        {
            cociente = num1 / num2;
            Console.WriteLine($"El resultado de la division es: {cociente}");
        }

        else
        {
            cociente = num2 / num1;
            Console.WriteLine($"El resultado de la division es: {cociente}");
        }

    }
}