using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {  
            String placeholder =new String('*',50); 
            double resultado=0,r,b,h;
            Console.Write($"{placeholder}\nPrograma para Geometria\n{placeholder}\n");
            while(true) 
                {   
                Console.WriteLine("Que area desea calcular?\n(c) Circulo \n(r)Rectangulo \n(t)Triangulo \n(s)Salir");
                String opcion = Console.ReadLine();
                if (opcion == "s")
                    break;
                switch(opcion){
                    case "c":
                        Console.WriteLine("Ingrese radio: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Figura circulo = new Figura(r);
                        resultado = circulo.getArea();
                        break;
                  case "r":
                      Console.WriteLine("Ingrese base: ");
                      b = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Ingrese altura");
                      h =Convert.ToDouble(Console.ReadLine());
                      Figura rectangulo = new Figura(b, h);
                      resultado = rectangulo.getArea();
                      break;
                  case "t":
                      Console.WriteLine("Ingrese base: ");
                      b = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Ingrese altura");
                      h =Convert.ToDouble(Console.ReadLine());
                      Figura triangulo = new Figura(b, h);
                      resultado = triangulo.getArea()/ 2;
                      break;
                }
                
                Console.Write($"\nEl resultado es :{resultado}.\n");
            }               
            Console.WriteLine("Gracias por usar el programa de cálculo geometrico.");}
    }
}