using System.Collections.Generic;

namespace CompositePC
{
    public abstract class Componente
    {
        protected string _nombre;

        public Componente(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerCosto { get; }
    }
}