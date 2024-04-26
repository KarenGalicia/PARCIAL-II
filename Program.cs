using System;
using PARCIAL_II.Abstracción;

namespace PARCIAL_II
{


    public abstract class Vehiculo
    {
        static void Main(string[] args)
        {
            // Crear un automóvil y una motocicleta
          Automovil miAuto = new Automovil("Toyota", "Corolla", 4, "Rojo");
          Motocicleta miMoto = new Motocicleta("Honda", "CBR 600RR", "Deportiva", 600);



            string color = Console.ReadLine();
            // Utilizar la abstracción para arrancar y detener los vehículos
            miAuto.Arrancar();
            miAuto.Detener();

            miMoto.Arrancar();
            miMoto.Detener();
  
         
        }
    }
}



