using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSharp.Models
{
    // Refresco hereda de Bebida (:) 
    // Hereda todas las propiedades y métodos de Bebida
    class Refresco : Bebida, IBebidaLight
    {
        public int Azucar {  get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado es 20 botellas");
        }

        // Constructor que llama al constructor de la clase base (Bebida) usando ': base'
        // Tiene un parámetro opcional (Nombre) con valor por defecto
        public Refresco(int Cantidad, string Nombre = "Refresco") : base(Nombre, Cantidad)
        {
            // No necesita cuerpo porque toda la lógica está en el constructor de Bebida
        }

    }
}
