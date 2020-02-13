using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BD
    {
        public string Nombre { get; set; }// para recibir y dar nombre de base de datos 
        public List<Tablas> Tablas { get; set; } // para armar la lista de tablas y bases de datos
    }
}
