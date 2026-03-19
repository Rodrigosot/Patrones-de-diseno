using System.Collections.Generic;

namespace CompositePC
{
    public class Ensamble : Componente
    {
        private List<Componente> _hijos;

        public Ensamble(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }

        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos;
        }

        public override int ObtenerCosto
        {
            get
            {
                int total = 0;
                foreach (var item in _hijos)
                {
                    total += item.ObtenerCosto;
                }
                return total;
            }
        }
    }
}