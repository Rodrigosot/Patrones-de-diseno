using System;

namespace Abstract_Factory
{
    // ====== FABRICA ABSTRACTA ======
    public abstract class MaterialFactory
    {
        public abstract Guia CrearGuia();
        public abstract Examen CrearExamen();
    }

    // ====== PRODUCTOS ABSTRACTOS ======
    public abstract class Guia
    {
        public abstract void Mostrar();
    }

    public abstract class Examen
    {
        public abstract void Aplicar();
    }

    // ====== PRODUCTOS CONCRETOS PRESENCIAL ======
    public class GuiaImpresa : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia impresa");
        }
    }

    public class ExamenEnPapel : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en papel");
        }
    }

    // ====== PRODUCTOS CONCRETOS VIRTUAL ======
    public class GuiaPDF : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia PDF");
        }
    }

    public class ExamenOnline : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en linea");
        }
    }

    // ====== PRODUCTOS CONCRETOS HIBRIDO ======
    public class GuiaHibrida : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostrando la guia en modalidad hibrida (semipresencial)");
        }
    }

    public class ExamenMixto : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen mixto (parte en linea y parte presencial)");
        }
    }

    // ====== FABRICAS CONCRETAS ======
    public class MaterialPresencialFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaImpresa();
        }

        public override Examen CrearExamen()
        {
            return new ExamenEnPapel();
        }
    }

    public class MaterialVirtualFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaPDF();
        }

        public override Examen CrearExamen()
        {
            return new ExamenOnline();
        }
    }

    public class MaterialHibridoFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaHibrida();
        }

        public override Examen CrearExamen()
        {
            return new ExamenMixto();
        }
    }

    // ====== PROGRAMA PRINCIPAL ======
    class Program
    {
        static void Main(string[] args)
        {
            MaterialFactory fabrica;

            // Modalidad Presencial
            fabrica = new MaterialPresencialFactory();
            Guia guia = fabrica.CrearGuia();
            Examen examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.WriteLine("");

            // Modalidad Virtual
            fabrica = new MaterialVirtualFactory();
            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.WriteLine("");

            // Modalidad Híbrida
            fabrica = new MaterialHibridoFactory();
            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.ReadKey();
        }
    }
}