using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T3
{
    internal class Cita
    {
        string[] cita = new string[0];


        public int numero { get; set; }
        public int estudiante { get; set; }
        public string enfermedad { get; set; }
        public double precio { get; set; }

        public void String()
        {
            Console.WriteLine("Ingresar Numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar enfermedad: ");
            enfermedad = Console.ReadLine();
            Console.WriteLine("Ingresar precio: ");
            precio = int.Parse(Console.ReadLine());
        }

        public void Lista()
        {
            Console.SetCursorPosition(10, 12);

            Console.Write("Numero: ");
            for (int i = 0; i < cita.Length; i++)
            {
                Console.SetCursorPosition(30, 12);
                Console.WriteLine(numero);
            }
            Console.Write("Enfermedad: ");
            for (int i = 0; i < cita.Length; i++)
            {
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(enfermedad);
                Console.SetCursorPosition(30, 13 + i);
                Console.WriteLine(cita[i]);
            }
            Console.WriteLine("Precio");
            for (int i = 0; i < cita.Length; i++)
            {
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(precio);
                Console.SetCursorPosition(30, 13 + i);
                Console.WriteLine(cita[i]);

            }
        }
    }
}

