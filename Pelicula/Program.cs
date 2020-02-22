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
    }


    class Program
    {
        static void Main(string[] args)
        {
            //se crean objetos
            pelicula p1=new pelicula();
            pelicula p2=new pelicula();

            P1.setTitulo("Green boo")
            P1.
        }
    }
}
