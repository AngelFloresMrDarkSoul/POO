using System;

namespace Pelicula
{
    class pelicula
    {
        //creacion de atributos
        public string Titulo;
        public int16 Año;
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
          public void setAño (int16 Año)
        {
            this.Año=Año;
        }
        public int16 getAño ()
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
        public Peli(string T, Int16 A)
        {
          this.Titulo=T;
          this.Año=A;
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
            pelicula p1=new pelicula();
            pelicula p2=new pelicula();


            P1.setTitulo("Parasitos");
            P1.setAño(2020);
            Console.WriteLine("{0}({1})","La Pelicula ganadora al oscar: "+ P1.getTitulo(), P1.getAño());
            P1.Titulo="Parasitos";
            P1.Año=2020;
            P1.Pais="Estados Unidos";
            P1.Director="Bong Joon-ho";
            Console.WriteLine( "Pelicula Ganadora del Oscar: "+ P1.Titulo +"\nAño: " +P1.Año );


            P2.setTitulo("Green book");
            P2.setAño(2019);
            Console.WriteLine("{0}({1})","La Pelicula ganadora al oscar: "+ P2.getTitulo(), P2.getAño());
            P2.Titulo="Green book";
            P2.Año=2019;
            P2.Pais="Estados Unidos";
            P2.Director="Peter Farrelly";
            Console.WriteLine( "Pelicula Ganadora del Oscar: "+ P2.Titulo +"\nAño: " +P2.Año );
            
        }
    }
}
