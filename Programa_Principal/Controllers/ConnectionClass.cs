using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal.Controllers
{
    public class ConnectionClass
    {
        private static string Cn = @"Data Source = YASB14082002; Initial Catalog= Facturas_Restaurante; Integrated Security=True";

        public static string Connection { get => Cn; set => Cn = value; }
    }
}
