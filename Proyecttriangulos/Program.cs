using System;

double anguloA;
double anguloB;
double anguloC;
double LadoA;
double LadoB;
double LadoC;
int respuesta;

do
{
    Console.WriteLine("Este programa puede realizar los siguientes metodos");
    List<string> metodos = new List<string>();
    metodos.Add("1.Metodo por senos");
    metodos.Add("2.Metodo por cosenos");
    metodos.Add("3.teorema de pitagoras");


    for (int i = 0; i < metodos.Count; i++)
    {
        Console.WriteLine(metodos[i]);
    }
    Console.WriteLine("Que metodo te gustaria realizar? ");
    respuesta = Convert.ToInt32(Console.ReadLine());

    if (respuesta == 1)
    {

        Console.WriteLine("\nRecuerda, necesito que me proporciones el valor de 2 angulos y por lo menos un lado del triangulo");
        Console.WriteLine("\nCual es el valor del primer angulo?");
        anguloA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCual es el valor del segundo angulo?");
        anguloB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCual es el valor del lado del triangulo?");
        LadoB = Convert.ToDouble(Console.ReadLine());

        double radanguloA = anguloA * Math.PI / 180;
        double radanguloB = anguloB * Math.PI / 180;
        double resultado = (LadoB * Math.Sin(radanguloA)) / Math.Sin(radanguloB);

        Console.WriteLine("El resultado es: " + resultado);


    }
    else if (respuesta == 2)
    {
        Console.WriteLine("\nRecuerda, necesito que me proporciones el valor de 2 lados y por lo menos un angulo");
        Console.WriteLine("\nCual es el valor del primer lado?");
        LadoA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCual es el valor del segundo lado?");
        LadoB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCual es el valor del angulo");
        anguloC = Convert.ToDouble(Console.ReadLine());

        double radanguloC = anguloC * Math.PI / 180;
        double resultado = Math.Sqrt(Math.Pow(LadoA, 2) + Math.Pow(LadoB, 2) - 2 * LadoA * LadoB * Math.Cos(radanguloC));
        Console.WriteLine("El resultado es: " + resultado);
    }
    else if (respuesta == 3)
    {
        Console.WriteLine("Necesito que me proporciones 2 lados del triangulo");
        Console.WriteLine("\nCual es el valor del primer lado?");
        LadoA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCual es el valor del segundo lado?");
        LadoB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCual es el valor del angulo");

        double resultado = Math.Sqrt(Math.Pow(LadoA, 2) + Math.Pow(LadoB, 2));
        Console.WriteLine("El resultado es" + resultado);


    }
    else
    {
        Console.WriteLine("Opcion invalida");
    }
} while (respuesta != 0);






