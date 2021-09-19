using System.Collections.Generic;
using HospiEnCasa.App.Dominio;//para utilizar el paciente

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> ObtenerPacientes();//obtiene toso los pacientes
        Paciente AddPaciente(Paciente paciente);//añade el paciente
        Paciente UpdatePaciente(Paciente paciente);//actualiza
        void DeletePaciente(int idPaciente);//elimina el paciente segun el id   
        Paciente GetPaciente(int idPaciente);//bsca un paciente segun el id
    }
}