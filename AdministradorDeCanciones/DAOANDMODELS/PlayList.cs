using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeCanciones.DAOANDMODELS
{
 
       public class Playlist
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int IdUsuario { get; set; } 

            public override string ToString()
            {
                return Nombre; 
            }
        }
    

}
