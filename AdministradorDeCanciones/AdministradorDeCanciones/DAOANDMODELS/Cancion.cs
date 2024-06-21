using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeCanciones.DAOANDMODELS
{
    public class Cancion
    {
        public int id { get; set; }
        public string titulo { get; set; }

        public string artista { get; set; }

        public byte[] foto_perfil { get; set; }


        public int ano { get; set; }

        public string genero {get; set;}
    }
}
