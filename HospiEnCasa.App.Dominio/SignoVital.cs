using System;

namespace HospiEnCasa.App.Dominio{
    public class SignoVital{
        public int id{set;get;}
        public DateTime fechaHora{set;get;}
        public Signo signo{set;get;}

        public double valor{set;get;}
    }
}