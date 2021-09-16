using System;

namespace HospiEnCasa.App.Dominio//porpio de la carpeta actual
{
    public class Persona{//atributos de la clase
        public int Id{ get ; set; }
        public string Nombre {set;get;}
        public string Apellido {set;get;}
        public string NumeroTelefono {set;get;}
        public Genero Genero {set;get;}
    }
}