using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal.Controllers
{
    public class CPlatillo
    {
        public static List<string>GetNamePlatillos()
        {
            return Models.Platillo.GetNames();
        }

        public static List<Models.Platillo> AddPlatillo(string v)
        {
            return Models.Platillo.AddPlatillo(v);
        }
    }
}
