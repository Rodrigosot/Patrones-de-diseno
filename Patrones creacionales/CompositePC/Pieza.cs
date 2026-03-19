using System.Collections.Generic;

namespace CompositePC
{
    public class Pieza : Componente
    {
        private int _costo;

        public Pieza(string nombre, int costo) : base(nombre)
        {
            _costo = costo;
        }

        public override void AgregarHijo(Componente c)
        {
            // No aplica (es hoja)
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerCosto
        {
            get { return _costo; }
        }
    }
}