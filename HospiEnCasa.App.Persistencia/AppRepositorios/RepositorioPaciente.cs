using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        /// <summary>description
        /// Metodod Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar 
        ///</summary>
        /// <param name="appContext"></param>//

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicional = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicional.Entity;
        }
        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if(pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
        
        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if(pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Familiar = paciente.Familiar;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
        IEnumerable<Paciente> IRepositorioPaciente.ObtenerPacientes()
        {
            return _appContext.Pacientes;//obtien todos
        }
        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }
    }
}
