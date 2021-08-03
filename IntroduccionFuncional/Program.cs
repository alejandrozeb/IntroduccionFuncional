using System;
using System.Collections.Generic;
using System.Linq;

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
                new People(){ Name = "christoper", Country = "Mexico", isDrunk = true},
                new People(){ Name = "Bezael", Country = "España", isDrunk = true},
                new People(){ Name = "Hector", Country = "Mexico", isDrunk = true},
                new People(){ Name = "Oscar", Country = "Mexico", isDrunk = false},
                new People(){ Name = "Manuel", Country = "Mexico", isDrunk = true}
            };

            //forma imperativa, mecanica clasica el como
            var namePeopleDrunk = new List<String>();
            foreach (var people in peoples) {
                if (people.isDrunk)
                    namePeopleDrunk.Add(people.Name.ToUpper());
            }

            //funcional
            //funcion extension podemos usarlas sin necesidad de heredarlas list tiene a IEnumerable
            //usamos extencions de generic
            var namePeopleDrunk2 = peoples.Where(d => d.isDrunk)
                .Select(d => d.Name.ToUpper());
            //no indicamos el como solo el que



            //conceptos basicos

          

    }
}
