using System;

namespace Pelicula
{
    class pelicula
        {
        //creacion de atributos
        public string Titulo;
        public Int16 Año;
        public string Pais;
        public string Director;
        //se crean los metodos
        public void setTitulo (string Titulo)
        {
            this.Titulo=Titulo;
        }
        public string getTitulo ()
        {
            return this.Titulo;
        }
        //Se crea el metodo Año
          public void setAño (Int16 Año)
        {
            this.Año=Año;
        }
        public int getAño ()
        {
            return this.Año;
        }
        //Se crea el metodo Pais
         public void setPais (string Pais)
        {
            this.Pais=Pais;
        }
        public string getPais ()
        {
            return this.Pais;
        }
        //Se crea el metodo Director
         public void setDirector (string Director)
        {
            this.Director=Director;
        }
        public string getDirector ()
        {
            return this.Director;
        }
        
         public void Imprime()
        {
            Console.WriteLine("{0}({1})",this.getTitulo(),this.getAño());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //se crean objetos
            pelicula P1 = new pelicula();
            pelicula P2 = new pelicula();




            P1.setTitulo("Parasitos");
            P1.setAño(2020);
            P1.Titulo="Parasitos";
            P1.Año=2020;
            P1.Pais="Estados Unidos";
            P1.Director="Bong Joon-ho";
            Console.WriteLine( "Pelicula Ganadora del Oscar: "+ P1.Titulo +"\nAño: " +P1.Año + "\nPais: : " + P1.Pais +"\nDirector:" + P1.Director);


            Console.WriteLine();
            Console.WriteLine();

            
            P2.setTitulo("Green book");
            P2.setAño(2019);
            P2.Titulo="Green book";
            P2.Año=2019;
            P2.Pais="Estados Unidos";
            P2.Director="Peter Farrelly";
            Console.WriteLine( "Pelicula Ganadora del Oscar: "+ P2.Titulo +"\nAño: " +P2.Año + "\nPais: : " + P2.Pais +"\nDirector:" + P2.Director );

        }
    }
}
