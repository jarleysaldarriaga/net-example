using System.Collections.Generic;
using HospiEnCasa.App.Dominio;//para utilizar el paciente

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioFamiliarDesignado
    {
        IEnumerable<FamiliarDesignado> ObtenerFamiliares();//obtiene toso los pacientes
        FamiliarDesignado AddFamiliar(FamiliarDesignado familiar);//añade el paciente
        FamiliarDesignado UpdateFamiliar(FamiliarDesignado familiar);//actualiza
        void DeleteFamiliar(int idFamiliar);//elimina el paciente segun el id   
        FamiliarDesignado GetFamiliar(int idFamiliar);//bsca un paciente segun el id
    }
}