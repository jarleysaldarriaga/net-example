using System.Collections.Generic;
using HospiEnCasa.App.Dominio;//para utilizar el paciente

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> ObtenerHistorias();//obtiene toso los pacientes
        Historia AddHistoria(Historia historia);//añade el paciente
        Historia UpdateHistoria(Historia historia);//actualiza
        void DeleteHistoria(int idHistoria);//elimina el paciente segun el id   
        Historia GetHistoria(int idHistoria);//bsca un paciente segun el id
    }
}