using System;
using System.Collections.Generic;
using System.Text;

namespace Cinepolis.Models
{
    public class ApiPeliculasHome
    {
        public class ph
        {
            public string idPelicula { get; set; }
            public string nombre { get; set; }
            public string synopsis { get; set; }
            public string anio { get; set; }
            public string clasificacion { get; set; }
            public string genero { get; set; }
            public string director { get; set; }
            public string duracion { get; set; }
            public string video { get; set; }
            public string banner { get; set; }
        }
    }
}
