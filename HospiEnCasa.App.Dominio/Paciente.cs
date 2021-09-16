using System;

namespace HospiEnCasa.App.Dominio{
    public class Paciente:Persona{
        public string direccion{set;get;}
        public double latitud{set;get;}
        public double longitud{set;get;}
        public string ciudad{set;get;}
        public DateTime fechaNacimiento{set;get;}
    }
}