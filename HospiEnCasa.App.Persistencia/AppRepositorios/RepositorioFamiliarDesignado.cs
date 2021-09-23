using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliarDesignado : IRepositorioFamiliarDesignado
    {
        private readonly AppContext _appContext;
        /// <summary>description
        /// Metodod Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar 
        ///</summary>
        /// <param name="appContext"></param>//

        public RepositorioFamiliarDesignado(AppContext appContext)
        {
            _appContext = appContext;
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.AddFamiliar(FamiliarDesignado familiar)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.Add(familiar);
            _appContext.SaveChanges();
            return familiarEncontrado.Entity;
        }
        void IRepositorioFamiliarDesignado.DeleteFamiliar(int idFamiliar)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliar);
            if(familiarEncontrado == null)
                return;
            _appContext.FamiliaresDesignados.Remove(familiarEncontrado);
            _appContext.SaveChanges();
        }
        
        FamiliarDesignado IRepositorioFamiliarDesignado.UpdateFamiliar(FamiliarDesignado familiar)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == familiar.Id);
            if(familiarEncontrado != null)
            {
                familiar.Nombre = familiar.Nombre;
                familiar.Apellidos = familiar.Apellidos;
                familiar.NumeroTelefono = familiar.NumeroTelefono;
                familiar.Genero = familiar.Genero;
                familiar.Parentesco = familiar.Parentesco;
                familiar.Correo = familiar.Correo;

                _appContext.SaveChanges();
            }
            return familiarEncontrado;
        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliarDesignado.ObtenerFamiliares()
        {
            return _appContext.FamiliaresDesignados;//obtien todos
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.GetFamiliar(int idFamiliar)
        {
            return _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliar);
        }
    }
    
}