using System;
using System.Collections.Generic;

namespace Actores
{
    
    class actores
    {
        private string nom;
        public actores(string n)
        {
            nom = n;
        }
        public void imprime()
        {
            Console.WriteLine(nom);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<actores> Actor = new List<actores>();
            Actor.Add(new actores("Will Smith"));
            Actor.Add(new actores("Dwayne Johnson"));
            Actor.Add(new actores("Zac Efron"));
            Actor.Add(new actores("Robert Downey Jr."));
 
            foreach(actores a in Actor)
            {
                a.imprime();
            }
        }
    }
}
