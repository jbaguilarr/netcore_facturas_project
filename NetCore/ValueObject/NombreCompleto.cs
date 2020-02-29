using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ValueObject
{
    public class NombreCompleto
    {
        public string Nombre { get; }
        public string Apellido { get; }

        
        public NombreCompleto(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    

    }

    
}
