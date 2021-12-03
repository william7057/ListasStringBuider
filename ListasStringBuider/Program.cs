using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Negocio;
namespace ListasStringBuider
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder cadena = new StringBuilder();
            NDatos person = new NDatos();
            Datos Persona = new Datos();
            Datos Persona2 = new Datos
            {
                Id = 13,
                Nombre = "PEPE",
                edad = 30
            };
            List<Datos> Personas = new List<Datos>();
            Persona.Id = 12;
            Persona.Nombre = "William";
            Persona.edad = 50;
            person.insertar(Persona);
            Personas.Add(Persona);
            Personas.Add(Persona2);
            string cadena2="";
            cadena2 = "william";
            cadena2 = cadena2 + " Huamantoma Cardenas";
            cadena2 = cadena2 + " Calle Lima 3621";
            cadena.Append("William");
            cadena.Append(" Huamantoma Cardenas");
            cadena.Append(" Calle Lima 3621");

            Console.WriteLine(cadena2);



            Console.ReadLine();

        }
    }
}
