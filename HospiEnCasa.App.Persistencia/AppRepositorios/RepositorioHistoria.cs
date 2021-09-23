using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext _appContext;
        /// <summary>description
        /// Metodod Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar 
        ///</summary>
        /// <param name="appContext"></param>//

        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
            var historiAdicional = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiAdicional.Entity;
        }
        void IRepositorioHistoria.DeleteHistoria(int idHistoria)
        {
            var historiAdicional = _appContext.Historias.FirstOrDefault(p => p.Id == idHistoria);
            if(historiAdicional == null)
                return;
            _appContext.Historias.Remove(historiAdicional);
            _appContext.SaveChanges();
        }
        
        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var historiAdicional = _appContext.Historias.FirstOrDefault(p => p.Id == historia.Id);
            if(historiAdicional != null)
            {
                historia.Diagnostico = historia.Diagnostico;
                historia.Entorno = historia.Entorno;

                _appContext.SaveChanges();
            }
            return historiAdicional;
        }
        IEnumerable<Historia> IRepositorioHistoria.ObtenerHistorias()
        {
            return _appContext.Historias;//obtien todos
        }
        Historia IRepositorioHistoria.GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(p => p.Id == idHistoria);
        }
    }
    
}