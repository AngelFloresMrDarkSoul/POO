using System.Collections.Generic;
using System;



namespace Musico
{
     class Musico
    {
        protected string nombre;
        public Musico(string n)
        {
            nombre=n;
        }
        
        public virtual void Afina()
        {
           Console.WriteLine("{0}, Afina su instrumento",nombre);
        }
        public virtual string Saluda()
        {
           return string.Format("Hola, soy {0}",nombre);
        }

         public virtual void Toca()
        {
          Console.WriteLine("Ave maria Cuando seras mia");
        }
    }

    class Bajista: Musico
    {
        private string bajo;
        public Bajista(string no, string bajo):base(no)
        {
            this.bajo=bajo;
        } 
  
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su bajo {1}",nombre,bajo);
        }
        public override string Saluda()
        {
            return base.Saluda()+" y soy bajista";
        }
        public override void Toca()
        {
            Console.WriteLine("row");
        }
        
        
    }

     class Guitarrista: Musico
    {
        private string guitarra;
        public Guitarrista(string no,string guitarra):base(no)
        {
           this.guitarra=guitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su guitarra {1}",nombre,guitarra);
        }

        public override string Saluda()
        {
            return base.Saluda()+" y soy guitarrista";
        }
        public override void Toca()
        {
            Console.WriteLine("riw");
        }
    }   
    class Baterista: Musico
    {
        private string bateria;
        public Baterista(string no, string bateria):base(no)
        {
            this.bateria=bateria;
        } 
        public override void Afina()
        {
            Console.WriteLine("{0} afinando su bateria {1}",nombre,bateria);
        }
        public override string Saluda()
        {
            return base.Saluda()+" y soy baterista";
        }
        public override void Toca()
        {
            Console.WriteLine("Da Dum Tsss ");
        }
    
     
    }





    class Program
    {
        static void Main(string[] args)
        {
           Musico Angel=new Musico("Angel");
            Bajista Ricardo=new Bajista("Ricardo","Arce");
            Guitarrista Alberto=new Guitarrista("Alberto","Hernandez");
            Baterista Juan=new Baterista("Juan","flores");

            List <Musico> grupo=new List<Musico>();
            grupo.Add(Angel);
            grupo.Add(Ricardo);
            grupo.Add(Alberto);
            grupo.Add(Juan);
            foreach(Musico m in grupo)
            {
                Console.WriteLine(m.Saluda());
                m.Afina();
                m.Toca();
            }
        }
    }
}