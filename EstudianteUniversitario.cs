using System;
namespace examen1
{
    class Estudianteuniversitario : Estudiante
    {
        public int creditos { set; get; }
        public int valor_creditos { set; get; }
        public Estudianteuniversitario (int creditos, int valor_creditos, string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.creditos = creditos;
            this.valor_creditos = valor_creditos;
        }
        public  void imprimir()
        {
            Console.WriteLine("Datos del estudiante");
            Console.WriteLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.WriteLine("Cedula de identidad: " +cedula_identidad);
            Console.WriteLine("Nombre de la institucion: " +nombre_institucion);
            Console.WriteLine("creditos: " +creditos);
            Console.WriteLine("valor de creditos: "+Precio_fijo);

        }
        public override void calcular() 
        {
            int total=0;
            total=creditos*valor_creditos;
            Console.WriteLine("el valor de la matricula es: $"+total);
            return total;
        }
    }
}