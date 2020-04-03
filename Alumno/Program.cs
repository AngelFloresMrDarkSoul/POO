using System;

namespace Alumno
{
    class alumno
    {

    protected string nombre;
    protected int matricula;


    public alumno(string nombre,int matricula)
    {
        this.nombre=nombre;
        this.matricula=matricula;
    }

    public virtual void imprime()
    {
        Console.WriteLine("Mi nombre es: {0} \nMi matricula es: {1}\n",this.nombre,this.matricula);
    }
}

class lincenciatura:alumno
{

    private string carrera;
    private int semestre;
    private string actservicio;

    
    public lincenciatura(string nombre,int matricula,string carrera,int semestre):base(nombre,matricula)
    {
        this.carrera=carrera;
        this.semestre=semestre;
        if(semestre>8) actservicio="Residencia";
        else actservicio="Servicio Social";
    }

    public override void imprime()
    {
        Console.WriteLine("Mi nombre es: {0} \nEstoy en el semestre: {1} \nEstudio en la carrera de: {2}\nMi matricula es: {3} \nActuamente estoy haciendo mi: {4}\n",this.nombre,this.semestre,this.carrera,this.matricula,this.actservicio);
    }
}

class posgrado:alumno
{

    private string especialidad;
    private int semestre;
    private string tema;

   
    public posgrado(string nombre,int matricula,string especialidad,int semestre,string tema):base(nombre,matricula)
    {
        this.especialidad=especialidad;
        this.semestre=semestre;
        this.tema=tema;
    }

    public override void imprime()
    {
        Console.WriteLine("Mi nombre es: {0} \nEstoy en el semestre: {1} \nCon la especialidad: {2}\nMi matricula es: {3} \nMi tema es: {4}\n",this.nombre,this.semestre,this.especialidad,this.matricula,this.tema);
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            alumno Angel = new alumno("Angel",19210933);
         Angel.imprime();
         lincenciatura Ricardo = new lincenciatura("Ricardo",19210733,"Licenciatura en informatica",3);
         Ricardo.imprime();
         posgrado Lineth = new posgrado("Lineth",19210848,"Ing Biomedica",5,"Anatomia");
         Lineth.imprime();
        }
    }
}
 
