using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSharp.Models
{
    // Definición de una clase
    // Una clase es una plantilla para crear objetos
    // Contiene atributos (datos) y métodos (comportamiento)
    class Bebida
    {
        // Propiedades (atributos con getters y setters automáticos)
        public string Nombre { get; set; }  // Propiedad pública (accesible desde fuera)
        public int Cantidad { get; set; }  // Otra propiedad pública

        // Constructor: método especial que se ejecuta al crear un objeto
        // Inicializa el estado del objeto
        public Bebida(string Nombre, int Cantidad)
        {
            // 'this' se refiere a la instancia actual del objeto
            this.Nombre = Nombre;      // Asigna el parámetro Nombre a la propiedad
            this.Cantidad = Cantidad;  // Asigna el parámetro Cantidad a la propiedad
        }

        // Método: acción que puede realizar el objeto
        // 'public' significa que puede ser llamado desde fuera de la clase
        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;  // Reduce la cantidad disponible
        }

        /*
         * Modificadores de acceso:
         * public: Accesible desde cualquier lugar.
         * private: Solo accesible dentro de la misma clase.
         * protected: Accesible dentro de la clase y sus derivadas.
         */
    }
}
