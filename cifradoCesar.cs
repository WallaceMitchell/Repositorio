//--------------------------------------------------------
//TP ADAPTACIÓN AL AMBIENTE DE TRABAJO "CÓDIGO CÉSAR"
//INTEGRANTES: WALLACE MITCHELL - JUAN IGNACIO VARISCO.
//--------------------------------------------------------

using System;

class Program
{

    //declaramos el alfabeto arbitrario.

    private static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

    public static void Main()
    {

        Console.WriteLine("Ingrese la frase a cifrar");

        string fraseCif = Console.ReadLine(); //guardamos la frase a cifrar ingresada por consola.

        while (string.IsNullOrEmpty(fraseCif))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            fraseCif = Console.ReadLine();
        }

        Console.WriteLine("Ingrese la frase a descrifrar");

        string fraseDescif = Console.ReadLine(); //guardamos la frase a descifrar ingresada por consola.

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

            index = (index + 7) % alfabeto.Length; //si se pasa del rango, vuelve al principio.

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

            index = (index - 7) + alfabeto.Length * BoolToInt(index - 7 < 0);

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