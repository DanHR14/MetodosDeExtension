using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine(nombre.saludar());
            Console.Read();

        }
    }

    public static class StringMetodoExtensión
    {
        public static string saludar(this string Nombre)
        {
            StringBuilder sb = new StringBuilder("Hola ");
            sb.Append(Nombre);
            return sb.ToString();
        }
    }
}
