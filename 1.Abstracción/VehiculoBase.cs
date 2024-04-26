namespace PARCIAL_II.Abstracción
{


    // Definición de la clase abstracta Vehiculo
    public abstract class VehiculoBase(string marca, string modelo)
    {




        // Propiedades
        public string Marca { get; set; } = marca;
        public string Modelo { get; set; } = modelo;
        public object? Color { get; internal set; }

        // Método abstracto para arrancar el vehículo
        public abstract void Arrancar();
        public abstract void Constrar();
        // Método abstracto para detener el vehículo
        public abstract void Detener();


    }
}
       