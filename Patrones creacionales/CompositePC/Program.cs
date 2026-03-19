using System;

namespace CompositePC
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========================
            // PC Gamer
            // ========================
            Componente pcGamer = new Ensamble("PC Gamer");

            Componente motherboard = new Ensamble("Motherboard");
            motherboard.AgregarHijo(new Pieza("CPU Ryzen 7", 6000));
            motherboard.AgregarHijo(new Pieza("RAM 32GB", 3000));
            motherboard.AgregarHijo(new Pieza("GPU RTX 4070", 12000));

            Componente almacenamiento = new Ensamble("Almacenamiento");
            almacenamiento.AgregarHijo(new Pieza("SSD 1TB", 1500));
            almacenamiento.AgregarHijo(new Pieza("HDD 2TB", 1200));

            pcGamer.AgregarHijo(motherboard);
            pcGamer.AgregarHijo(almacenamiento);
            pcGamer.AgregarHijo(new Pieza("Fuente 750W", 1200));

            // ========================
            //  PC Oficina
            // ========================
            Componente pcOficina = new Ensamble("PC Oficina");

            Componente mbOficina = new Ensamble("Motherboard");
            mbOficina.AgregarHijo(new Pieza("CPU i5", 3000));
            mbOficina.AgregarHijo(new Pieza("RAM 16GB", 1500));

            Componente storageOficina = new Ensamble("Almacenamiento");
            storageOficina.AgregarHijo(new Pieza("SSD 512GB", 1000));

            pcOficina.AgregarHijo(mbOficina);
            pcOficina.AgregarHijo(storageOficina);
            pcOficina.AgregarHijo(new Pieza("Fuente 500W", 800));

            // ========================
            // PC Estudiante
            // ========================
            Componente pcEstudiante = new Ensamble("PC Estudiante");

            Componente mbEstudiante = new Ensamble("Motherboard");
            mbEstudiante.AgregarHijo(new Pieza("CPU Ryzen 5", 4000));
            mbEstudiante.AgregarHijo(new Pieza("RAM 16GB", 1500));

            pcEstudiante.AgregarHijo(mbEstudiante);
            pcEstudiante.AgregarHijo(new Pieza("SSD 512GB", 1000));
            pcEstudiante.AgregarHijo(new Pieza("Fuente 600W", 900));

            // ========================
            // 📊 RESULTADOS
            // ========================
            Console.WriteLine($"Costo {pcGamer.Nombre}: {pcGamer.ObtenerCosto}");
            Console.WriteLine($"Costo {pcOficina.Nombre}: {pcOficina.ObtenerCosto}");
            Console.WriteLine($"Costo {pcEstudiante.Nombre}: {pcEstudiante.ObtenerCosto}");

            Console.ReadLine();
        }
    }
}