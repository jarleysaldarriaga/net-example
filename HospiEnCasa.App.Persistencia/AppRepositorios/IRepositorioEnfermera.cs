using System.Collections.Generic;
using HospiEnCasa.App.Dominio;//para utilizar el paciente

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioEnfermera
    {
        IEnumerable<Enfermera> ObtenerEnfemeras();//obtiene toso los pacientes
        Enfermera AddEnfermera(Enfermera enfermera);//añade el paciente
        Enfermera UpdateEnfermera(Enfermera enfermera);//actualiza
        void DeleteEnfermera(int idEnfermera);//elimina el paciente segun el id   
        Enfermera GetEnfermera(int idEnfermera);//bsca un paciente segun el id
    }
}