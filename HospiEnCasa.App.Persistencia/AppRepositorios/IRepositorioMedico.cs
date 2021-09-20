using System.Collections.Generic;
using HospiEnCasa.App.Dominio;//para utilizar el paciente

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> ObtenerMedicos();//obtiene toso los pacientes
        Medico AddMedico(Medico medico);//añade el paciente
        Medico UpdateMedico(Medico medico);//actualiza
        void DeleteMedico(int idMedico);//elimina el paciente segun el id   
        Medico GetMedico(int idMedico);//bsca un paciente segun el id
    }
}