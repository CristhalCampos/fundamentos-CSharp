using System;
using System.Collections.Generic;
using FundamentosCSharp.Models;

namespace FundamentosCSharp
{
    // La clase Program es la clase principal que contiene el punto de entrada (Main) de la aplicación
    class Program
    {
        // El método Main es el primer método que se ejecuta al iniciar la aplicación
        // 'static' indica que pertenece a la clase y no a una instancia
        // 'void' significa que no retorna ningún valor
        // 'args' puede contener argumentos pasados al programa al ejecutarlo
        static void Main(string[] args)
        {
            /**********************************************************
             * SECCIÓN 1: TIPOS DE DATOS BÁSICOS (VARIABLES PRIMITIVAS)
             **********************************************************/

            // Enteros sin signo (solo positivos)
            byte num = 255;          // 1 byte (8 bits). Rango: 0 a 255
            ushort numeroCortoPositivo = 3;  // 2 bytes (16 bits). Rango: 0 a 65,535
            uint numeroPositivo = 18;        // 4 bytes (32 bits). Rango: 0 a 4,294,967,295
            ulong numeroLargoPositivo = 443432; // 8 bytes (64 bits). Rango: 0 a 18,446,744,073,709,551,615
            Console.WriteLine(num);
            Console.WriteLine(numeroCortoPositivo);
            Console.WriteLine(numeroPositivo);
            Console.WriteLine(numeroLargoPositivo);

            // Enteros con signo (positivos y negativos)
            sbyte numNegativo = -128;  // 1 byte (8 bits). Rango: -128 a 127
            short numeroCorto = 3;      // 2 bytes (16 bits). Rango: -32,768 a 32,767
            int numero = -18;           // 4 bytes (32 bits). Rango: -2,147,483,648 a 2,147,483,647
            long numeroLargo = 99850;   // 8 bytes (64 bits). Rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
            Console.WriteLine(numNegativo);
            Console.WriteLine(numeroCorto);
            Console.WriteLine(numero);
            Console.WriteLine(numeroLargo);

            // Tipos de datos numéricos decimales (para números con parte fraccionaria)
            float numeroFloat = 15.2f;   // 4 bytes (precisión de ~6-9 dígitos). Sufijo 'f' obligatorio
            double numeroDouble = 15.2;  // 8 bytes (precisión de ~15-17 dígitos). El sufijo 'd' es opcional
            decimal numeroDecimal = 15.2m; // 16 bytes (precisión de 28-29 dígitos). Sufijo 'm' obligatorio (para dinero/calculos financieros)
            Console.WriteLine(numeroFloat);
            Console.WriteLine(numeroDouble);
            Console.WriteLine(numeroDecimal);

            // Tipos de datos de texto
            char caracter = 'A';          // 2 bytes (unicode UTF-16). Comillas simples
            string cadena = "esto es una cadena"; // Tamaño variable (2 bytes por carácter + overhead)
            Console.WriteLine(caracter);
            Console.WriteLine(cadena);

            // Otros tipos de datos comunes
            DateTime fecha = DateTime.Now;  // 8 bytes (almacena fecha y hora con precisión de 100ns)
            bool siOno = false;            // 1 byte (aunque solo necesita 1 bit, la CPU trabaja con bytes)
            Console.WriteLine(fecha);
            Console.WriteLine(siOno);

            // Tipo especial, acepta null
            int? numeroNull = null; // Con el operador '?' (Nullable Types)
            Console.WriteLine(numeroNull);

            // Inicialización de variables
            int numeroInicial = new int(); // Se inicializa en 0 (valor por defecto para int)
            Console.WriteLine(numeroInicial);

            /**********************************************************
             * SECCIÓN 2: PALABRAS RESERVADAS Y TIPOS IMPLÍCITOS
             **********************************************************/

            // 'var' permite declarar variables sin especificar el tipo explícitamente
            // El tipo se infiere del valor asignado (debe inicializarse)
            // Una vez definido el tipo, no puede cambiarse
            var pais = "Venezuela"; // El compilador infiere que es de tipo string
            Console.WriteLine(pais);

            // 'const' define una constante (valor que no puede cambiar)
            const int numeroConstante = 10;
            Console.WriteLine(numeroConstante); 

            /**********************************************************
             * SECCIÓN 3: OBJETOS Y CLASES
             **********************************************************/

            // Objeto anónimo (sin clase definida)
            // Útil para encapsular datos temporales sin crear una clase
            // No se puede acceder a sus propiedades si se declara como 'object'
            object persona = new { nombre = "Cristh", apellido = "Campos" };
            Console.WriteLine(persona);

            // Con 'var' sí podemos acceder a las propiedades
            var carro = new { marca = "chevrolet", color = "azul" };
            Console.WriteLine(carro);

            // Creación de objeto a partir de una clase (Bebida)
            Bebida bebida1 = new Bebida("CocaCola", 1000);
            bebida1.Beberse(600); // Llamada a método del objeto
            Console.WriteLine(bebida1.Cantidad); // Acceso a propiedad

            // Herencia: Refresco hereda de Bebida
            Refresco refresco = new Refresco(500);
            Console.WriteLine(refresco.Nombre);

            /**********************************************************
             * SECCIÓN 4: COLECCIONES (ARREGLOS Y LISTAS)
             **********************************************************/

            // Arreglo: tamaño fijo, declarado con corchetes []
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            // Acceso por índice (base 0)
            int numero1 = numeros[0];
            Console.WriteLine(numero1);

            // Iteración con for (controlamos el índice)
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("iteración " + i + ": el número es " + numeros[i]);
            }

            // Iteración con foreach (más simple, pero sin acceso al índice)
            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }

            // Lista: tamaño dinámico, requiere System.Collections.Generic
            List<int> lista = new List<int>() { 50, 100 };

            // Métodos comunes de List
            lista.Remove(100); // Elimina un elemento
            lista.Add(150);    // Añade un elemento

            foreach (var n in lista)
            {
                Console.WriteLine("elemento " + n);
            }

            // Lista de objetos personalizados
            List<Refresco> refrescos = new List<Refresco>() { new Refresco(750) };
            refrescos.Add(new Refresco(1000, "Refresco grande"));
            refrescos.Add(refresco);

            foreach (var r in refrescos)
            {
                Console.WriteLine(r.Nombre);
            }

            var bebidaLight = new TeHelado(100);
            MostrarRecomendacion(bebidaLight);
        }

        static void MostrarRecomendacion(IBebidaLight bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}