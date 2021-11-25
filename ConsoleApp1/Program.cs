using System;

namespace Programapractica
{
    class Program
    {
        static double circulo()
        {
            double pi = 3.14;
            Console.WriteLine("Ingrese radio: ");
            double vradio = Convert.ToDouble(Console.ReadLine());
            return  pi * vradio * vradio;
        }

        static double rectangulo()
        {
            Console.WriteLine("Ingrese la base: ");
            double vbase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
             double valtura = Convert.ToDouble(Console.ReadLine());
             return  vbase* valtura;
        }

        static double triangulo()
        {
            Console.WriteLine("Ingrese la base: ");
            double vbase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            double valtura = Convert.ToDouble(Console.ReadLine());
            return vbase * valtura / 2;
        }
        
        static void Main(string[] args)
        {  String placeholder =new String('*',50); 
            double resultado=0;
            Console.Write($"{placeholder}\nPrograma para Geometria\n{placeholder}\n");
            while (true) 
            {   Console.WriteLine("Que area desea calcular?\n(c) Circulo \n(r)Rectangulo \n(t)Triangulo \n(s)Salir");
                String opcion = Console.ReadLine();
                if (opcion == "s")
                    break;
                switch(opcion){
                    case "c":
                        resultado = circulo();
                      break;
                  case "r":
                      resultado = rectangulo();
                      break;
                  case "t":
                      resultado = triangulo();
                      break;
                }

                Console.Write($"\nEl resultado es :{resultado}.");
            }               
            Console.WriteLine("Gracias por usar el programa de cálculo geometrico.");}
    }
}