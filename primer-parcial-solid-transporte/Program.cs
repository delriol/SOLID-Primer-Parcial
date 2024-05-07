using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITransporte> transportes = new List<ITransporte>();
            TransporteRepository transporteRepository = new TransporteRepository();

            Avion avion1 = new Avion("AVION 01", 0, 100, 0, 000);
            transportes.Add(avion1);

            Avion avion2 = new Avion("AVION 02", 0, 100, 0, 100);
            transportes.Add(avion2);

            Tren tren1 = new Tren("TREN 01", 0, 100);
            transportes.Add(tren1);

            Console.WriteLine("Inicio del viaje :)");

            //Permite guardar el estado actual del transporte en una base de datos
            foreach (ITransporte transporte in transportes)
            {
                transporteRepository.guardar(transporte);
            }

            Console.WriteLine("Fin del viaje :)");
        }
    }
}
