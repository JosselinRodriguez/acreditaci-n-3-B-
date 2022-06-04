using System;
namespace examen1
{
    class Program
    {
        static void Main (string[]args)
        {
        Estudianteprimaria estudiante_primaria = new Estudianteprimaria(100, "Maria juaquina","santos mendoza", 134567896,"eloy alfaro");
        estudiante_primaria.imprimir();
        estudiante_primaria.calcular();

        Estudiantesecundaria estudiante_secundaria = new Estudiantesecundaria(10, 25, "Edwin alejandro","Mera Mera", 1343598785,"tecnico");
        estudiante_secundaria.imprimir();
        estudiante_secundaria.calcular();

        Estudianteuniversitario estudiante_universitario = new Estudianteuniversitario(20, 12, "Denisse Josselin","Rodriguez chancay", 1309897708,"Uleam");
        estudiante_universitario.imprimir();
        estudiante_universitario.calcular();

        }

    }

}
