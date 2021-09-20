using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioEnfermera : IRepositorioEnfermera
    {
        private readonly AppContext _appContext;
        /// <summary>description
        /// Metodod Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar 
        ///</summary>
        /// <param name="appContext"></param>//

        public RepositorioEnfermera(AppContext appContext)
        {
            _appContext = appContext;
        }

        Enfermera IRepositorioEnfermera.AddEnfermera(Enfermera enfermera)
        {
            var enfermeraAdicional = _appContext.Enfermeras.Add(enfermera);
            _appContext.SaveChanges();
            return enfermeraAdicional.Entity;
        }
        void IRepositorioEnfermera.DeleteEnfermera(int idEnfermera)
        {
            var enfermeraEncontrado = _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);
            if(enfermeraEncontrado == null)
                return;
            _appContext.Enfermeras.Remove(enfermeraEncontrado);
            _appContext.SaveChanges();
        }
        
        Enfermera IRepositorioEnfermera.UpdateEnfermera(Enfermera enfermera)
        {
            var enfermeraEncontrado = _appContext.Enfermeras.FirstOrDefault(p => p.Id == enfermera.Id);
            if(enfermeraEncontrado != null)
            {
                enfermeraEncontrado.Nombre = enfermera.Nombre;
                enfermeraEncontrado.Apellidos = enfermera.Apellidos;
                enfermeraEncontrado.NumeroTelefono = enfermera.NumeroTelefono;
                enfermeraEncontrado.Genero = enfermera.Genero;
                enfermeraEncontrado.TarjetaProfesional = enfermera.TarjetaProfesional;
                enfermeraEncontrado.HorasLaborales = enfermera.HorasLaborales;

                _appContext.SaveChanges();
            }
            return enfermeraEncontrado;
        }
        IEnumerable<Enfermera> IRepositorioEnfermera.ObtenerEnfemeras()
        {
            return _appContext.Enfermeras;//obtien todos
        }
        Enfermera IRepositorioEnfermera.GetEnfermera(int idEnfermera)
        {
            return _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);
        }
    }
    
}