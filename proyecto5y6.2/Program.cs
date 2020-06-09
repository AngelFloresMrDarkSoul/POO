﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace proyecto5y6._2
{
   class Producto
    {
        public string codigo;
        public string descripcion;
        public double precio;
        public string departamento;
        public int likes;

        public Producto(string c, string d, double p, string m, int l){
            codigo = c; descripcion = d; precio = p; departamento = m; likes = l;
        }
       
    }
    class productoDB
    {
        

        //Escribir producto TXT
        public static void WriteToTXT(string archivo, List<Producto> productos)
        {
            try
            {
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0} {1} {2} {3} {4}", p.descripcion, p.precio, p.codigo, p.departamento, p.likes);
                Console.WriteLine("{0} {1} {2} {3} {4}", p.descripcion, p.precio, p.codigo, p.departamento, p.likes);
            }
            txtOut.Close();
            }catch(Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
        }

        






        //Leer producto TXT
        public void ReadFromTXT(string archivo, List<Producto> productos)
        {
			try
			{			
				FileStream fs1=new FileStream(archivo,FileMode.Open,FileAccess.Read);//crea
				using(StreamReader txtOut=new StreamReader(fs1)){//transcribe
					string line;				
					while((line = txtOut.ReadLine()) != null){//para que valla checando renglon x renglon
						string[] columnas = line.Split("|");//para dividir el constructor
						productos.Add(new Producto(columnas[0], columnas[1], double.Parse(columnas[2]), columnas[3], int.Parse(columnas[4])));
					}
				}
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
        
        }


        //Binary
        public void WriteToBIN(string archivo){
			try
			{
				FileStream fs=new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
				using(BinaryWriter binOut = new BinaryWriter(fs)){
                    IEnumerable<Producto> producto = null;
                    foreach (Producto p in producto ){
						binOut.Write(p.codigo);
						binOut.Write(p.descripcion);
						binOut.Write(p.precio);
						binOut.Write(p.departamento);
						binOut.Write(p.likes);
					}
				}
			}
			catch( Exception e){
                Console.WriteLine("Hubo un error");
                Console.WriteLine(e.Message);
            }
  
 
     }

        internal static void WriteToBIN(string v, List<Producto> productos)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("A54sa", "Placa Arduino", 14.23d, "Electronica", 13));
            productos.Add(new Producto("Dsda6", "Brazo metalico", 5.51d, "Mecanica", 54));
            productos.Add(new Producto("Edf51", "Laptop con pantalla LCD", 22200.23d, "Computacion", 68));
            productos.Add(new Producto("Psda9", "Multimetro", 500.36d, "Electricidad", 2));

            //Metodos de escritura TXT
            productoDB.WriteToTXT("productos.txt", productos);
            productoDB.WriteToTXT("productos.txt", productos);

           //Metdos escritura BIN
            productoDB.WriteToBIN("productos.bin",productos);
        }
    }
 }
 
