using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___ej6_
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //6)

            //string maximo = lista.Max;

            //Console.WriteLine(lista.Max);
            //Console.WriteLine(lista.Min);
            //Console.WriteLine(lista.First);
            //Console.WriteLine(lista.Last);
            //Console.WriteLine(lista.OrderByDescending);
            //Console.WriteLine(lista.OrderBy);

            //7)

            var resultado = 0;
            string nuevoingreso;
            string nuevoingreso2;
            string nuevoingreso3;
            string nuevoingreso4;
            bool sale = false;
            var numero = 0;
            var numero2 = 0;
            var numero3 = 0;
            var numero4 = 0;
            bool esnumero = false;
            while (!sale)
            {


                
                Console.WriteLine();
                Console.WriteLine("Ingrese la operacion que desea hacer:");
                Console.WriteLine("1)Suma");
                Console.WriteLine("2)Resta");
                Console.WriteLine("3)Multiplicación");
                Console.WriteLine("4)División");
                Console.WriteLine("5)Borrar Pantalla");
                Console.WriteLine("6)Salir");
                string strReadKey = Console.ReadKey().KeyChar.ToString();

                switch (int.Parse(strReadKey))
                {
                    case 1:
                        esnumero = false;
                        Console.WriteLine();
                        Console.Write("Ingrese el valor que desea sumar:");                      
                        while(!esnumero)
                        {
                            nuevoingreso = Console.ReadLine();
                            esnumero = int.TryParse(nuevoingreso, out numero);
                        }
                        
                        resultado = resultado + numero;
                        Console.WriteLine();
                        Console.WriteLine($"El resultado es: {resultado}");
                        Console.ReadKey();
                        break;

                    case 2:
                        esnumero = false;
                        Console.WriteLine();
                        Console.Write("Ingrese el valor que desea restar:");
                        while (!esnumero)
                        {
                            nuevoingreso2 = Console.ReadLine();
                            esnumero = int.TryParse(nuevoingreso2, out numero2);
                        }

                        resultado = resultado - numero2;
                        Console.WriteLine();
                        Console.WriteLine($"El resultado es: {resultado}");
                        Console.ReadKey();
                        break;

                    case 3:
                        esnumero = false;
                        Console.WriteLine();
                        Console.Write("Ingrese el valor que desea multiplicar:");
                        while (!esnumero)
                        {
                            nuevoingreso3 = Console.ReadLine();
                            esnumero = int.TryParse(nuevoingreso3, out numero3);
                        }

                        resultado = resultado * numero3;
                        Console.WriteLine();
                        Console.WriteLine($"El resultado es: {resultado}");
                        Console.ReadKey();
                        break;

                    case 4:
                        esnumero = false;
                        Console.WriteLine();
                        Console.Write("Ingrese el valor que desea dividir:");
                        while (!esnumero)
                        {
                            nuevoingreso4 = Console.ReadLine();
                            esnumero = int.TryParse(nuevoingreso4, out numero4);
                        }

                        resultado = resultado / numero4;
                        Console.WriteLine();
                        Console.WriteLine($"El resultado es: {resultado}");
                        Console.ReadKey();
                        break;

                    case 5:
                        resultado = 0;
                        Console.WriteLine();
                        Console.WriteLine($"El resultado es: {resultado}");
                        Console.ReadKey();
                        break;

                    case 6:
                        sale = true;
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("El valor ingresado existe");
                        break;


                }

            }
        }
    }
}
