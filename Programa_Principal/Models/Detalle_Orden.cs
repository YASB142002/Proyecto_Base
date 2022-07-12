using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal.Models
{
    public class Detalle_Orden
    {
        int Id_Detalle;
        int Id_Empleado;
        DateTime Fecha;
        int Id_Cliente;
        bool Tipo_Pago;
        int Id_Mesa;
    }
}
