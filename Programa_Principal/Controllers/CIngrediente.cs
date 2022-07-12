using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal.Controllers
{
    class CIngrediente
    {
        public static List<string> GetIngredientes()
        {
            return Models.Ingrediente.GetIngredientesDeUnPlatillo();
        }
        public static List<Models.Ingrediente> AdddgvExtra(string ingrediente)
        {
            return Models.Ingrediente.AdddgvExtra(ingrediente);
        }

        public static List<Models.Ingrediente> RemovedgvExtra(string v)
        {
            return Models.Ingrediente.RemovedgvExtra(v);
        }
    }
}
