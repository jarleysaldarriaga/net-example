using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());
        private static IRepositorioEnfermera _repoEnfermera = new RepositorioEnfermera(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity FrameWork!");
            //AddPaciente();
            //BuscarPaciente(1);
            //AddMedico();
            //BuscarMedico();
            AddEnfermera();
        }

        private static void AddEnfermera()
        {
            var enfermera = new Enfermera{
                Nombre = "Camila",
                Apellidos = "Dias",
                NumeroTelefono = "3216599874",
                Genero = Genero.Femenino,
                TarjetaProfesional = "jhkjhsadas4654",
                HorasLaborales = 8
            };
            _repoEnfermera.AddEnfermera(enfermera);
        }

        /*private static void AddPaciente()
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
        }*/

        /*private static void AddMedico()
        {
            var medico = new Medico{
                Nombre = "Camilo",
                Apellidos = "Vargas",
                NumeroTelefono = "3056897825",
                Genero = Genero.Masculino,
                Especialidad ="Cardiobascular",
                Codigo = "232326565",
                RegistroRethus = "21546sed5asd"
            };
            _repoMedico.AddMedico(medico);
        }*/

        /*private static void BuscarMedico(string Mnombre)
        {
            var medico = _repoMedico.GetMedico(Mnombre);
            Console.WriteLine(medico.Nombre +  " " + medico.Apellidos);
        }*/

        /*private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }*/
    }
}
