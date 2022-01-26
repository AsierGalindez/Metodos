using System;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Hola3veces();

            //    static void Hola3veces()
            //    {
            //        Console.WriteLine("hola");
            //        Console.WriteLine("hola");
            //        Console.WriteLine("hola");
            //    }


            //NumSaludos(3);
            //Console.WriteLine("");
            //NumSaludos(5);


            //static void NumSaludos(int num)
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        Console.WriteLine("Hola");
            //    }

            //}
            // EJERCICIO 3 MÉTODOS. 

            //Console.WriteLine("mete un parametro");

            //int parametro1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("mete otro parametro");

            //int parametro2 = Int32.Parse(Console.ReadLine());


            //static void SumarDosParametros(int num1, int num2)
            //{
            //    Console.WriteLine(num1 + num2);
            //}

            //SumarDosParametros(parametro1, parametro2);

            //EJERCICIO 4 MÉTODOS

            //Console.WriteLine("mete un número para calcular factorial");

            //int parametro1 = Int32.Parse(Console.ReadLine());
            //Factorial(parametro1);

            //static void Factorial(int num1)
            //{

            //    for (int i = (num1 - 1); i > 0; i--)
            //    {
            //        num1 = num1 * i;
            //    }
            //    Console.WriteLine(num1);
            //}

            //EJERCICIO 5 MÉTODOS PAR/IMPAR

            //Console.WriteLine("mete un número para calcular SI ES PAR O IMPAR");

            //int parametro1 = Int32.Parse(Console.ReadLine());

            //if (EsPar(parametro1) == true) 
            //{
            //    Console.WriteLine("Es par");
            //}
            //else {
            //    Console.WriteLine("Es impar");
            //        }

            //static Boolean EsPar(int num)
            //{
            //    if (num % 2 ==0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;

            //    }
            //}
            //EJERCICIO 6 MÉTODOS

            //static void MostrarTabla (int [] tabla)
            //{
            //    for (int i = 0; i < tabla.Length; i++)
            //    {
            //        Console.WriteLine(tabla[i]);
            //    }
            //}
            //static void MostrarTablalreves(int[] tabla)
            //{
            //    for (int i = (tabla.Length - 1); i >= 0; i--)
            //    {
            //        Console.WriteLine(tabla[i]);
            //    }
            //}

            //int [] tabla = {3 , 5, 7};

            //MostrarTabla(tabla);

            //MostrarTablalreves(tabla);

            //EJERCICIO 7 ARRAY Y BOOLEAN

            //static void TablasTrueFalse (bool verdad, int [] tabla)
            //{
            //    if (verdad == true)
            //    {
            //        for (int i = 0; i < tabla.Length; i++)
            //        {
            //            Console.WriteLine(tabla[i]);
            //        }
            //    }
            //    else
            //    {
            //        for (int i = (tabla.Length - 1); i >= 0; i--)
            //        {
            //            Console.WriteLine(tabla[i]);
            //        }
            //    }

            //}
            //int [] tabla = {5, 15, 59};
            //bool verdad = true;


            //TablasTrueFalse(verdad, tabla);
            //verdad = false;
            //TablasTrueFalse(verdad, tabla);

            // EJERCICIO 8 CONTADOR CIFRAS

            //Console.WriteLine("mete un número y te digo cuantas cifras tiene");
            //int num =Int32.Parse(Console.ReadLine());

            //static int NumCifras(int num)

            //{
            //    if (num < 10) return 1;
            //    if(num < 100) return 2;
            //    if(num < 1000) return 3;
            //    if(num < 10000) return 4;
            //    if(num < 100000) return 5;
            //    if(num < 1000000) return 6;
            //    if (num < 10000000) return 7;
            //    if (num < 100000000) return 8;
            //    if (num < 1000000000) return 9;
            //    return 10;


            //}


            //Console.WriteLine(NumCifras(num));

            //EJERCICIO 9 división dos números



            //bool exit = false;

            //void DivisonNum()
            //{
            //    Console.WriteLine("dame un valor");
            //    int num1 = Int32.Parse(Console.ReadLine());


            //    Console.WriteLine("dame un valor");
            //    int num2 = Int32.Parse(Console.ReadLine());
            //    if (num2 == 0)
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine(num1 / num2);
            //        exit = false;
            //    }

            //}

            //while (exit == false)
            //{
            //    DivisonNum();

            //}
            //EJERCICIO 10 NÚMERO MÁS GRANDE
            //bool maspeque = true;
            //Console.WriteLine("Dame un número");
            //int num1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Dame otro número");
            //int num2 = Int32.Parse(Console.ReadLine());

            //static void Tamanio(int num1, int num2, bool maspeque)
            //{
            //    if (num1 < num2)
            //    {
            //        maspeque = true;
            //    }
            //    else
            //    {
            //        maspeque = false;
            //    }

            //}
            //    Tamanio(num1, num2, maspeque);

            //    Console.WriteLine(maspeque);

            //EJERCICIO 11 BISIESTO

            //int num1 = 1;
            //while (num1 != 0)

            //{
            //    Console.WriteLine("Dame un AÑO PARA SABER SI ES BISIESTO");

            //    num1 = Int32.Parse(Console.ReadLine());

            //    if (num1 == 0)
            //    {

            //    }
            //    else if (AnioBisiesto(num1) == true)
            //    {
            //        Console.WriteLine("El año " + num1 + " es bisiesto");
            //    }
            //    else
            //    {
            //        Console.WriteLine("el año " + num1 + " no es bisiesto");
            //    }
            //}

            //static bool AnioBisiesto(int anio)
            //{
            //    {
            //        if (anio % 4 == 0)
            //        {
            //            return true;
            //        }
            //        else if (anio % 100 == 0)
            //        {
            //            return true;
            //        }
            //        else if (anio % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else return false;
            //    }
            //}
            //     EJERCICIO 12 NUMEROS ALEATORIOS


            // int num1;
            // int num2;
            // int num3;


            // Console.WriteLine("¿Cuantos números quieres crear?");
            // num1 = Int32.Parse(Console.ReadLine());

            // Console.WriteLine("entre qué números");
            // num2 = Int32.Parse(Console.ReadLine());
            // num3 = Int32.Parse(Console.ReadLine());


            // CrearNum(num1, num2, num3);

            //static void CrearNum(int num1, int num2, int num3)
            // {
            //     int tabla;
            //     for (int i = 0; i < num1; i++)
            //     {
            //         Random rnd = new Random();
            //         tabla = rnd.Next(num2, num3 + 1);
            //         Console.WriteLine(tabla);
            //     }
            // }

            // EJERCICIO 13 EXCHANGE

            //static void Exchange()
            //{
            //    Console.WriteLine("Dime la cantidad de euros");
            //    int eur =Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("Dime a que moneda quieres cambiar");
            //    string moneda = Console.ReadLine();

            //    if (moneda == "libras" || moneda == "LIBRAS")
            //    {
            //        Console.WriteLine("en libras tienes" + (eur * 0, 86));
            //    }
            //    else if (moneda == "yenes" || moneda == "YENES")
            //    {
            //        Console.WriteLine("tienes " + (eur * 129.852) + " yenes");

            //    }
            //    else if (moneda == "dólares" || moneda == "DOLARES")
            //    {
            //        Console.WriteLine("tienes" + (eur * 1.28611) + " dólares");
            //    }
            //    else
            //    {
            //        Console.WriteLine("tienes que meter dólares, yenes o libras");
            //    }
            //}

            //Exchange();

            //EJERCICIO 14 CUENTAVOCALES

            //string word = Console.ReadLine();
            //CuentaVocales(word);


            //static void CuentaVocales(string word)
            //{
            //    string letra;
            //    int n = 0;

            //    for (int i = 0; i < word.Length; i++)

            //    {
            //        letra = word.Substring(i, 1);
            //        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            //        {
            //            n++;

            //        }

            //    }
            //    Console.WriteLine(n);
            //}

            //EJERCICIO 15 CUENTAPALABRAS

            //string text = Console.ReadLine();


            //static void CuentaPalabras(string texto)
            //{
            //    string letra;
            //    int n = 1;
            //    for (int i = 0; i < texto.Length; i++)
            //    {
            //        letra = texto.Substring(i, 1);
            //        if (letra == " ")
            //        {
            //            n++;

            //        }
            //    }
            //    Console.WriteLine(n);
            //}
            //CuentaPalabras(text);


            //EJERCICIO 16 VUELTA AL STRING

            string palabra = Console.ReadLine();
            
            LaVuelta(palabra);

            static void LaVuelta(string palabra)
            {
                string swtch = "";

                for (int i = palabra.Length; i < 0; i--)
                {
                    swtch = swtch + palabra.Substring(i, 1);
                }
                Console.WriteLine(swtch);
            }

        }

    }
}
