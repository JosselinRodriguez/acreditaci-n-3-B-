using System;
namespace examen1
{
    class Estudianteprimaria: Estudiante
    {
        
        public int valor { set; get; }
        public Estudianteprimaria (int valor, string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.valor = valor;
        }
        public void imprimir()
        {
            Console.WriteLine("Datos del estudiante");
            Console.WriteLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.WriteLine("Cedula de identidad: " +cedula_identidad);
            Console.WriteLine("Nombre de la institucion: " +nombre_institucion);
        }
        public int calcular() 
        {
            Console.WriteLine("El valor de la matricula es $" +Precio_fijo);
           return Precio_fijo;

        }     
    }   
}