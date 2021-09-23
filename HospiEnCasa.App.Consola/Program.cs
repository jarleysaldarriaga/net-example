
using System.Collections.Generic;
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
        private static IRepositorioFamiliarDesignado _repoFamiliar = new RepositorioFamiliarDesignado(new Persistencia.AppContext());

        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        private static IRepositorioSugerenciaCuidado  _repoSugerencia = new RepositorioSugerenciaCuidado(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la consola se esta ejecutando las pruebas");
            //AddPaciente();
            //BuscarPaciente(1);
            //AddMedico();
            //BuscarMedico();
            //AddEnfermera();
            //AddFamiliar();
            //AddSugerencia();
            //AddHistoria();
        }

    

        /*private static void AddSugerencia(){
            var sugerencia = new SugerenciaCuidado{
                FechaHora = new DateTime(10/03/1999),
                Descripcion = "Tomar Loratadina de mk de 10 ml, evitar tocar los lugares donde tenga os zarpullidos"
            };
            _repoSugerencia.AddSugerencia(sugerencia);
            /*var sugerencia1 = new SugerenciaCuidado{
                FechaHora = new DateTime(15/08/1999),
                Descripcion = "Tomar cloracepan de 200 ml"
            };
            _repoSugerencia.AddSugerencia(sugerencia1);
        }*/

        /*private static void AddHistoria()
        {
            var historia = new Historia{
                Diagnostico = "Paciente que sufre de problemas del corazon",
                Entorno = "Corazon",
                Sugerencias = new List<SugerenciaCuidado>()//Add(AddSugerencia())
            };
            _repoHistoria.AddHistoria(historia);
        }*/

        /*private static void AddFamiliar()
        {
            var familiar = new FamiliarDesignado{
                Nombre = "andres",
                Apellidos = "aguero",
                NumeroTelefono = "3266599781",
                Genero = Genero.Masculino,
                Parentesco = "Tio",
                Correo = "andres123@gmail.com"
            };
            _repoFamiliar.AddFamiliar(familiar);
        }*/

        /*private static void AddEnfermera()
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
        }*/

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
