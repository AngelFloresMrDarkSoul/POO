using System;

namespace Duracion
{
     class Duracion
    {
       public  int Horas;
       public int Minutos;
       public int Segundos;
        public Duracion(int H, int M, int S )
        {
            this.Horas=H;
            this.Segundos=S;
            this.Minutos=M;
        }
        public void imprimeHMS()
       {
        Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos, Segundos);
       }
       public void conversionSeg()
       {
          int S;
          S=(Horas*3600)+(Minutos*60)+Segundos;
            Console.WriteLine("Hora en Segundos: {0}", S);
       }

       public void conversionMin()
       {
           int M;
           M=(Horas*60)+Minutos+(Segundos/60);
           Console.WriteLine("Hora en Minutos: {0}",M);
       }
        public Duracion(int S)
        {
            this.Segundos=S;

            Horas=(int) S/3600;
            Minutos=(int)(S-(Horas*3600))/60;
            Segundos=(int)S-(Horas*3600)-(Minutos*60);
        }
        public void imprimeSaHMS()
        {
            Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos,Segundos);
        }
        public static Duracion operator +(Duracion hms, Duracion SaHMS)
        {
            int S=0;

            S= ((hms.Horas+SaHMS.Horas)*3600)+((hms.Minutos+SaHMS.Minutos)*60)+(hms.Segundos+SaHMS.Segundos);

            return new Duracion(S);     
        }
        public void imprimeSuma()
        {
            Console.WriteLine("La suma es: {0}:{1}:{2} hrs",Horas,Minutos,Segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Duracion hms=new Duracion(8,30,50);
           hms.imprimeHMS();
           hms.conversionSeg();
           hms.conversionMin();

           Duracion SaHMS=new Duracion(7000);
           Console.WriteLine("7000 segundos equivalen a: ");
           SaHMS.imprimeSaHMS();

           Duracion Suma;
           Suma=hms+SaHMS;
           Suma.imprimeSuma();
        }
    }
}
