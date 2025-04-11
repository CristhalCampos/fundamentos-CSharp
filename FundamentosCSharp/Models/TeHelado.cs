using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSharp.Models
{
    class TeHelado : Bebida, IBebidaLight
    {
        public int Azucar { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo recomendado es 10 botellas");
        }

        // Constructor que llama al constructor de la clase base (Bebida) usando ': base'
        // Tiene un parámetro opcional (Nombre) con valor por defecto
        public TeHelado(int Cantidad, string Nombre = "Te Helado") : base(Nombre, Cantidad)
        {
            // No necesita cuerpo porque toda la lógica está en el constructor de Bebida
        }

    }
}
