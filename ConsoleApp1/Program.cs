using System;

namespace Programapractica
{
    class Program
    {
        static void Main(string[] args)
        {  String placeholder =new String('*',50); 
            double pi = 3.14, vradio, vbase, valtura,resultado=0;
            Console.Write($"{placeholder}\nPrograma para Geometria\n{placeholder}\n");
            while (true) 
            {   Console.WriteLine("Que area desea calcular?\n(c) Circulo \n(r)Rectangulo \n(t)Triangulo \n(s)Salir");
                String opcion = Console.ReadLine();
                if (opcion == "s")
                    break;
                switch(opcion){
                    case "c":
                        Console.WriteLine("Ingrese radio: ");
                      vradio = Convert.ToDouble(Console.ReadLine());
                      resultado = pi * vradio * vradio;
                      break;
                  case "r":
                      Console.WriteLine("Ingrese la base: ");
                      vbase = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Ingrese la Altura");
                      valtura = Convert.ToDouble(Console.ReadLine());
                      resultado = (vbase * valtura);
                      break;
                  case "t":
                      Console.WriteLine("Ingrese la base: ");
                      vbase = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Ingrese la altura: ");
                      valtura = Convert.ToDouble(Console.ReadLine());
                      resultado = (vbase * valtura) / 2;
                      break;
                }

                Console.Write($"\nEl resultado es :{resultado}.");
            }               
            Console.WriteLine("Gracias por usar el programa de cálculo geometrico.");}
    }
}