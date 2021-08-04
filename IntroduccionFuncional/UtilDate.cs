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
        
    }
}
