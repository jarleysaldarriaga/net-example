using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        /// <summary>description
        /// Metodod Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar 
        ///</summary>
        /// <param name="appContext"></param>//

        public RepositorioMedico(AppContext appContext)
        {
            _appContext = appContext;
        }

        Medico IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicional = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicional.Entity;
        }
        void IRepositorioMedico.DeleteMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
            if(medicoEncontrado == null)
                return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
        
        Medico IRepositorioMedico.UpdateMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == medico.Id);
            if(medicoEncontrado != null)
            {
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellidos = medico.Apellidos;
                medicoEncontrado.NumeroTelefono = medico.NumeroTelefono;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.Codigo = medico.Codigo;
                medicoEncontrado.RegistroRethus = medico.RegistroRethus;

                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }
        IEnumerable<Medico> IRepositorioMedico.ObtenerMedicos()
        {
            return _appContext.Medicos;//obtien todos
        }
        Medico IRepositorioMedico.GetMedico(int idMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
        }
    }
}
