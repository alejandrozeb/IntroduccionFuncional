using System;
using System.Collections.Generic;

namespace IntroduccionFuncional
{
    class Program
    {

        public class People { 
            public string Name { get; set; }
            public string Country { get; set; }
            public bool isDrunk { get; set; }
        }
        static void Main(string[] args)
        {
            var peoples = new List<People>()
            {
                
                //chuck descubre el calculo lamda y turing apoya 
                //en muchos lenguajes de programacion los paraigmas conviven con otros como ser poo o imperativo
                //ejemplos Java, C, javascript
                new People(){ Name = "christoper", Country = "Mexico", isDrunk = true}
            };
            
        }
    }
}
