using System;
namespace examen1
{
    class Estudiantesecundaria : Estudiante
    {
        

        public int Nivel { set; get; }
        public int Precio_fijo { set; get; }
        public Estudiantesecundaria (int Nivel, int Precio_fijo, string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.Nivel = Nivel;
            this.Precio_fijo = Precio_fijo;
        }
        public void imprimir()
        {
            Console.WriteLine("Datos del estudiante");
            Console.WriteLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.WriteLine("Cedula de identidad: " +cedula_identidad);
            Console.WriteLine("Nombre de la institucion: " +nombre_institucion);
            Console.WriteLine("Nivel: " +Nivel);
            Console.WriteLine("Precio fijo: "+Precio_fijo);
        }
        public void calcular() 
        {
            int total=0;
            total=Nivel_cursado*Precio_fijo;
            Console.WriteLine("el valor de la matricula es: $"+total);
            return total;
        }
        
    }   
}