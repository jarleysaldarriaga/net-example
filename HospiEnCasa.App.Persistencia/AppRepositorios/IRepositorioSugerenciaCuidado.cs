using System.Collections.Generic;
using HospiEnCasa.App.Dominio;//para utilizar el paciente

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado
    {
        IEnumerable<SugerenciaCuidado> ObtenerSugerencia();//obtiene toso los pacientes
        SugerenciaCuidado AddSugerencia(SugerenciaCuidado sugerenciaCuidado);//añade el paciente
        SugerenciaCuidado UpdateSugerencia(SugerenciaCuidado sugerenciaCuidado);//actualiza
        void DeleteSugerencia(int idSugerenciaCuidado);//elimina el paciente segun el id   
        SugerenciaCuidado GetSugerencia(int idSugerenciaCuidado);//bsca un paciente segun el id
    }
}