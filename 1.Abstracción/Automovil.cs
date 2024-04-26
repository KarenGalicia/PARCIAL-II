using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static PARCIAL_II.Abstracción.VehiculoBase;

namespace PARCIAL_II.Abstracción
{
    internal class Automovil(string marca, string modelo, int puertas, string color) : VehiculoBase(marca, modelo)
        
    {
        // Atributos adicionales
        public new string Color { get; set; } = color;




        // Implementación del método Arrancar para Automovil
        public override void Arrancar()
            {
                Console.WriteLine("El automóvil {0} {1} ha arrancado.", Marca, Modelo);
            }

        public override void Constrar()
        {
            throw new NotImplementedException();
        }

        // Implementación del método Detener para Automovil
        public override void Detener()
            {
                Console.WriteLine("El automóvil {0} {1} se ha detenido.", Marca, Modelo);
            }
        }
    }

