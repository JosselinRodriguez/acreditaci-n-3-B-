using System;
namespace examen1
{
    class Estudiante

    {
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int cedula_identidad { set; get; }
        public string nombre_institucion { set; get; }
    
    public Estudiante(string nombre, string apellido, int cedula_identidad, string nombre_institucion)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.cedula_identidad = cedula_identidad;
        this.nombre_institucion = nombre_institucion; 
    }
    }
}