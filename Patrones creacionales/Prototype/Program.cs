using System;

namespace PrototypeExamenes
{
    public abstract class ExamenPrototype
    {
        protected string claveMateria;
        protected string nombreAsignatura;
        protected string docente;
        protected string salon;
        protected string grupo;

        public ExamenPrototype(string clave, string asignatura, string docente, string salon, string grupo)
        {
            this.claveMateria = clave;
            this.nombreAsignatura = asignatura;
            this.docente = docente;
            this.salon = salon;
            this.grupo = grupo;
        }

        public void MostrarExamen()
        {
            Console.WriteLine("Materia: " + nombreAsignatura);
            Console.WriteLine("Clave: " + claveMateria);
            Console.WriteLine("Docente: " + docente);
            Console.WriteLine("Salon: " + salon);
            Console.WriteLine("Grupo: " + grupo);
            Console.WriteLine("----------------------------");
        }

        public abstract ExamenPrototype Clonar();
    }

    public class ExamenPatrones : ExamenPrototype
{
    public ExamenPatrones(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenProgramacion : ExamenPrototype
{
    public ExamenProgramacion(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenBaseDatos : ExamenPrototype
{
    public ExamenBaseDatos(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenRedes : ExamenPrototype
{
    public ExamenRedes(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenSistemasOperativos : ExamenPrototype
{
    public ExamenSistemasOperativos(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenIA : ExamenPrototype
{
    public ExamenIA(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenSeguridad : ExamenPrototype
{
    public ExamenSeguridad(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

public class ExamenIngenieriaSoftware : ExamenPrototype
{
    public ExamenIngenieriaSoftware(string clave, string asignatura, string docente, string salon, string grupo)
        : base(clave, asignatura, docente, salon, grupo) { }

    public override ExamenPrototype Clonar()
    {
        return (ExamenPrototype)this.MemberwiseClone();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ExamenPrototype examenBase = new ExamenPatrones(
            "DSW-101",
            "Patrones de Diseño",
            "Dr. Carlos López",
            "A1",
            "5A"
        );

        Console.WriteLine("Examen original:");
        examenBase.MostrarExamen();

        ExamenPrototype examenGrupoB = examenBase.Clonar();

        Console.WriteLine("Examen clonado para otro grupo:");
        examenGrupoB.MostrarExamen();

        ExamenPrototype examenRedes = new ExamenRedes(
            "RED-202",
            "Redes de Computadoras",
            "Ing. Ana Torres",
            "B3",
            "4B"
        );

        examenRedes.MostrarExamen();
    }
}
}

