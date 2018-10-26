using System;
using System.Collections.Generic;
using shared;

namespace data
{
    public class ListaPersonajes
    {
        public IEnumerable<Personaje> ObtenerPersonajes() {
            return new List<Personaje>() {
                new Personaje() { Nombre = "Goku"},
                new Personaje() { Nombre = "Vegeta"}
            };
        }
    }
}
