using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionFuncional
{
    class UtilDate
    {
        public static int Days(DateTime from) => (DateTime.Now - from).Days;
        //esrta funcion no es funcinal
        //la transparencia referencial siemrpe devuelve el mismo resultado

        //funcional
        public static int DaysFun(DateTime from, DateTime now) => (now - from).Days;
        //funciones puras es la que te regresa el mismo valor con las misma entrada
        //o funcion honesta si no existe depedendencia tampoco importara los inputs


        //funciones puras
        private static string cad1 = "Hola Borarchos";

        public static void Concat(String Cad2) => cad1 += Cad2;

        //rompe la transparencia referencial
        //una funcion pura es la que devuelve siempre lo mismo
        public static void Concat2(StringBuilder Cad1, string Cad2) => Cad1.Append(Cad2);
        //igual rmpe con el paradigma funcional no devuelve el mismo valor
        //en POO string builder se manda como referencial

        public static string Concat(string Cad1, string Cad2) => (Cad1 + Cad2);

        //no importa que la funcion siempre va a devolver lo mismo esta funcion pura si cumple 
        //con el paradigma

       //link trae funciones a los enumerables
       //-------delegados---------


    }
}
