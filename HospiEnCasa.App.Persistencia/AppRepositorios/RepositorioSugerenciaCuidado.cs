using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {
        private readonly AppContext _appContext;
        /// <summary>description
        /// Metodod Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar 
        ///</summary>
        /// <param name="appContext"></param>//

        public RepositorioSugerenciaCuidado(AppContext appContext)
        {
            _appContext = appContext;
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerencia(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaAdicional = _appContext.SugerenciasCuidados.Add(sugerenciaCuidado);
            _appContext.SaveChanges();
            return sugerenciaAdicional.Entity;
        }
        void IRepositorioSugerenciaCuidado.DeleteSugerencia(int idSugerencia)
        {
            var sugerenciaAdicional = _appContext.SugerenciasCuidados.FirstOrDefault(p => p.Id == idSugerencia);
            if(sugerenciaAdicional == null)
                return;
            _appContext.SugerenciasCuidados.Remove(sugerenciaAdicional);
            _appContext.SaveChanges();
        }
        
        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSugerencia(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaAdicional = _appContext.SugerenciasCuidados.FirstOrDefault(p => p.Id == sugerenciaCuidado.Id);
            if(sugerenciaAdicional != null)
            {
                sugerenciaAdicional.FechaHora = sugerenciaCuidado.FechaHora;
                sugerenciaAdicional.Descripcion = sugerenciaCuidado.Descripcion;
                

                _appContext.SaveChanges();
            }
            return sugerenciaAdicional;
        }
        IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.ObtenerSugerencia()
        {
            return _appContext.SugerenciasCuidados;//obtien todos
        }
        SugerenciaCuidado IRepositorioSugerenciaCuidado.GetSugerencia(int idSugerencia)
        {
            return _appContext.SugerenciasCuidados.FirstOrDefault(p => p.Id == idSugerencia);
        }
    }
}
