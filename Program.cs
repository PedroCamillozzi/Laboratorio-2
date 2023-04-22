using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         string inputTexto;
         Boolean band = true;
            Console.WriteLine("Ingrese un texto");
         inputTexto = System.Console.ReadLine();
         while (band == true) {
                for (int i = 0; i < inputTexto.Length; i++)
                {
                    band = Char.IsLetter(inputTexto[i]);

                }
            if (band == false) {
                
                 System.Console.WriteLine("Porfavor escriba solo letras");
               }
            else
                {
                    Menu(inputTexto);
                }
            }
            System.Console.ReadKey();





            void  Menu(string texto)
            {
                int opcion;
                System.Console.WriteLine("1- Frase en May, 2-Frase en Min, 3-Cantidad De Caracteres, 4-Fin");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion) { 
                
                    case 1: FraseMay(texto); break;
                    case 2: FraseMin(texto); break;
                    case 3: CantidadDeCaracteres(texto); break;
                    case 4: Console.WriteLine("Adios"); break;
                    default: Console.WriteLine("Elija una de las 4 opciones"); break;
                }
            } 


          void FraseMay(string texto)
            {
                Console.WriteLine(texto.ToUpper());
            }
          void FraseMin(string texto)
            {
                Console.WriteLine(texto.ToLower());
            }
          void CantidadDeCaracteres(string texto)
            {
                Console.WriteLine(texto.Length);
            }
        } 
       
    }
}
