using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace T3
{
    public class Estudiante
    {
        string[] estudia = new string[0];
        int posicion;

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Universidad { get; set; }

        public void String()
        {
            Console.WriteLine("Ingresar codigo de estudiante: ");
            Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar nombre de estudiante: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresar universidad: ");
            Universidad = Console.ReadLine();
        }
        public void Lista()
        {
            Console.SetCursorPosition(10, 12);

            Console.Write("Numero: ");
            for (int i = 0; i < estudia.Length; i++)
            {
                Console.SetCursorPosition(30, 12);
                Console.WriteLine(Codigo);
            }
            Console.Write("Enfermedad: ");
            for (int i = 0; i < estudia.Length; i++)
            {
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(Nombre);
                Console.SetCursorPosition(30, 13 + i);
                Console.WriteLine(estudia[i]);
            }
            Console.WriteLine("Precio");
            for (int i = 0; i < estudia.Length; i++)
            {
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(Universidad);
                Console.SetCursorPosition(30, 13 + i);
                Console.WriteLine(estudia[i]);
            }
        }
        public void Eliminar(string Uni)
        {
            int indice = Array.IndexOf(estudia, Uni);
            if (indice != -1)
            {
                for (int i = indice; i < estudia.Length - 1; i++)
                {
                    estudia[i] = estudia[i + 1];
                }
                Array.Resize(ref estudia, estudia.Length - 1);
                posicion--;

                Console.WriteLine("\nElemento eliminado");
            }
            else
            {
                Console.WriteLine("INVALIDO");
            }
        }
    }
}


