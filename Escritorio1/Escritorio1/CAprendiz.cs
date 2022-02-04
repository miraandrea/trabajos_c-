using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio1
{
    class CAprendiz
    {
         public string nombre { set; get; }
         public string apellido { set; get; }
         public int edad { set; get; }

        public string mostrarDatos()
        {
            string resultado = "este es un mensaje";
            return resultado;
        }

    }
}
