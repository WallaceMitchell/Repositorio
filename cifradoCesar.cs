//--------------------------------------------------------
//TP ADAPTACIÓN AL AMBIENTE DE TRABAJO "CÓDIGO CÉSAR (Apartado 4 - Distancia)"
//INTEGRANTES: WALLACE MITCHELL - JUAN IGNACIO VARISCO.
//--------------------------------------------------------

using System;

class Program
{

    //declaramos el alfabeto arbitrario y las distancias.
    private static int distancia1;
    private static int distancia2;
    private static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

    public static void Main()
    {

        Console.WriteLine("Ingrese la frase a cifrar");

        string fraseCif = Console.ReadLine(); //guardamos la frase a cifrar ingresada por consola.
        Console.WriteLine("Ingrese la distancia destinada a cifrar");
        distancia1 = Convert.ToInt32(Console.ReadLine()); //ingresamos el valor de la distancia deseada.

        while (string.IsNullOrEmpty(fraseCif))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            fraseCif = Console.ReadLine();
        }

        Console.WriteLine("Ingrese la frase a descrifrar");

        string fraseDescif = Console.ReadLine(); //guardamos la frase a descifrar ingresada por consola.

        Console.WriteLine("Ingrese la distancia destinada a descifrar");
        distancia2 = Convert.ToInt32(Console.ReadLine()); //ingrasamos el valor de la distancia deseada.

        while (string.IsNullOrEmpty(fraseDescif))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            fraseDescif = Console.ReadLine();
        }

        Program program = new Program();

        Console.WriteLine("Mensaje cifrado: ");

        Console.WriteLine(program.Cifrado(fraseCif));
        //mostramos resultados de la aplicación de las funciones.
        Console.WriteLine("Mensaje descrifrado: ");

        Console.WriteLine(program.Descifrado(fraseDescif));

    }

    private string Cifrado(string frase)
    {

        string stringAux = ""; //declaramos un string vacío y lo vamos llenando con un bucle for.

        for (int x = 0; x < frase.Length; x++)
        {

            char caracter = frase[x];

            int index = -1;

            for (int y = 0; (y < alfabeto.Length) && (index == -1); y++)
            {

                if (alfabeto[y] == caracter)
                {

                    index = y;

                }

            }

            index = (index + distancia1) % alfabeto.Length;

            stringAux += alfabeto[index];

        }

        return stringAux;

    }

    private string Descifrado(string frase)

    {

        string stringAux = "";

        for (int x = 0; x < frase.Length; x++)
        {

            char caracter = frase[x];

            int index = -1;

            for (int y = 0; (y < alfabeto.Length) && (index == -1); y++)
            {

                if (alfabeto[y] == caracter)
                {

                    index = y;

                }

            }

            index = (index - distancia2) + alfabeto.Length * BoolToInt(index - distancia2 < 0);

            stringAux += alfabeto[index];

        }

        return stringAux;

    }

    private static int BoolToInt(Boolean c) //funcion auxiliar para que True y False se pasen a unos y ceros.
    {

        if (c)
        {

            return 1;

        }
        else
        {

            return 0;

        }

    }

}
