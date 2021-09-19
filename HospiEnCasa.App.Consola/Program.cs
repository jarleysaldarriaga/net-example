using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity FrameWork!");
            AddPaciente();
            BuscarPaciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente{
                Nombre = "Andres",
                Apellidos = "Perez",
                NumeroTelefono = "3012659872",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.0706F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1999, 10, 03)
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
    }
}
