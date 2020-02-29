using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.ValueObject
{
    public class Direccion : ValueObject
    {
        public string Barrio { get; private set; }
        public string Calle { get; private set; }
        public int Numero { get; private set; }


        public Direccion(string barrio, string calle, int numero)
        {
            Barrio = barrio;
            Calle = calle;
            Numero = numero;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Barrio;
            yield return Calle;
            yield return Numero;
        }

    }
}
