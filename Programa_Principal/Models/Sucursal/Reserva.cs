using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal.Models.Sucursal
{
    public class Reserva
    {
        int Id_Sucursal;
        DateTime Fecha_Reserva;
        DateTime Fecha_Llegada;
        int Cantidad_Personas;
        int Id_Mesa;
        bool Servicio_Especial;
        bool Tipo_Pago;
    }
}
