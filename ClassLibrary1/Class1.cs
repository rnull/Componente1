﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    /*
     * 
     * Requerimientos::
     * 1. Concatenr 2 cadenas
     * 2. Regresar el tamaño (length) de la cadaena.
     * 3. ¿Contiene alguna letra?
     * 4. ¿Contiene numeros?
     * 
     */
    public static class Class1
    {

        //metodo para concatenar dos cadenas
        public static string concatena(string s1,string s2 ) 

        {

            Console.WriteLine("Este es el resultado de las cadenas");
            return s1 + s2;
        }

        
        /*
         * 
         * Tipos definicos por C#
         * 
         */

        //(//
        //revisa el largo de la palabra 
        public static int tamaño(string tam)
        {
            return tam.Length; 
        }
        //revisa si existe la letra 
        public static Boolean letra(string let, string palabra)
        { 

            if (palabra.Contains(let)){
                Console.WriteLine("Si existe");
                return true;
            }
            else
            {
                Console.WriteLine("No existe");
            return false;
            }
            
        }
        //Revisa si tiene un numero
        public static Boolean numero(string num, string palabra1)
        {

            if (palabra1.Contains(num))
            {

                Console.WriteLine("Si existe numero");
                return true;
            }
            else
            {
                Console.WriteLine("No existe numero");
                return false;
            }
            
            
            
            }
        }


        
    }
}
