using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex6
/*
 * Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
 Google :even and odd number
 */
{
    public class Program
    { 
        public static void Main(string[] args)
        
        { 
            int numarIntrodus;
            int numarPar;
            Console.WriteLine("Introduceti numarul: ");
            numarIntrodus = Convert.ToInt32(Console.ReadLine());
            numarPar = numarIntrodus % 2;
            if (numarPar == 0)
            { 
                Console.WriteLine("Numarul este par !");
            } 
            else 
            { 
                Console.WriteLine("Numarul este impar !");
            }
        }
    }
}