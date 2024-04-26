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
    internal class Motocicleta: VehiculoBase

    {
        public string Tipo { get; set; }
        public int Cilindrada { get; set; }

        // Constructor que inicializa los atributos Tipo y Cilindrada, y llama al constructor de la clase base para inicializar Marca y Modelo
        public Motocicleta(string marca, string modelo, string tipo, int cilindrada)
            : base(marca, modelo)
        {
            Tipo = tipo;
            Cilindrada = cilindrada;
        }

       
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override void Arrancar()
        {
            throw new NotImplementedException();
        }

        public override void Constrar()
        {
            throw new NotImplementedException();
        }

        public override void Detener()
        {
            throw new NotImplementedException();
        }
    }
    }
